using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.Models;
using FR.BusinessObjects.Models.VietQR;
using FR.DataAccess;
using FR.Services.IService;
using HotChocolate;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace FR.Services.Service
{
    public class BankService : IBankService
    {
        private readonly BillDAO _dao;
        private const string Uri = "https://api.vietqr.io/";


        private static readonly HttpClientHandler HttpHandler = new HttpClientHandler() { MaxConnectionsPerServer = 6, UseProxy = false};
        private static readonly HttpClient HttpClient = new(HttpHandler);
        private static readonly IConfigurationBuilder builder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        private static readonly IConfigurationRoot config = builder.Build();

        public BankService(BillDAO dao)
        {
            _dao = dao;
            if (HttpClient.BaseAddress == null)
            {
                HttpClient.BaseAddress = new Uri(Uri);
                HttpClient.DefaultRequestHeaders.Accept.Clear();
                HttpClient.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                HttpClient.DefaultRequestHeaders.Add("x-client-id", config.GetSection("QrInformation")["x-client-id"]);
                HttpClient.DefaultRequestHeaders.Add("x-api-key", config.GetSection("QrInformation")["x-api-key"]);
            }
        }

        public async Task<BankingResponse> GetQRAsync(string billId)
        {
            try
            {
                Bill bill = _dao.GetBillById(billId);
                var requestData = new
                {
                    accountNo = config.GetSection("QrInformation")["accountNo"],
                    accountName = config.GetSection("QrInformation")["accountName"],
                    acqId = config.GetSection("QrInformation")["acqId"],
                    format = config.GetSection("QrInformation")["format"],
                    template = config.GetSection("QrInformation")["template"],
                    //TODO: Change billId to new format FR-XXXX
                    addInfo = config.GetSection("QrInformation")["addInfo"].Replace("{billId}", billId.Substring(0, 5)),
                    amount = bill.TotalAmount,
                };

                string jsonBody = JsonConvert.SerializeObject(requestData);

                HttpResponseMessage response = await HttpClient.PostAsync("/v2/generate/", 
                    new StringContent(jsonBody, Encoding.UTF8, "application/json"));

                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                BankingResponse bankingResponse = JsonConvert.DeserializeObject<BankingResponse>(responseBody);
                return bankingResponse;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error calling API: {e.Message}");
                throw;
            }
        }
    }
}
