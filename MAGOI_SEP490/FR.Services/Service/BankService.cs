using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using FR.Services.IService;
using HotChocolate;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace FR.Services.Service
{
    public class BankService : IBankService
    {
        private const string Uri = "https://api.vietqr.io/";

        private static readonly HttpClient HttpClient = new();
        private static readonly IConfigurationBuilder builder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        private static readonly IConfigurationRoot config = builder.Build();

        public BankService()
        {
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

        public async Task<string> GetQRAsync()
        {
            try
            {
                var requestData = new
                {
                    accountNo = config.GetSection("QrInformation")["accountNo"],
                    accountName = config.GetSection("QrInformation")["accountName"],
                    acqId = config.GetSection("QrInformation")["acqId"],
                    format = config.GetSection("QrInformation")["format"],
                    template = config.GetSection("QrInformation")["template"]
                };

                string jsonBody = Newtonsoft.Json.JsonConvert.SerializeObject(requestData);

                HttpResponseMessage response = await HttpClient.PostAsync("/v2/generate/", 
                    new StringContent(jsonBody, Encoding.UTF8, "application/json"));

                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error calling API: {e.Message}");
                throw;
            }
        }
    }
}
