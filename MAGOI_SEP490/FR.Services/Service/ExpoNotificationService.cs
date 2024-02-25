using System;
using System.Net.Http.Headers;
using FR.BusinessObjects.Models;
using FR.BusinessObjects.Models.ExpoNotification;
using FR.Services.IService;
using Newtonsoft.Json;

namespace FR.Services.Service
{
	public class ExpoNotificationService : IExpoNotificationService
	{
        private const string ExpoBackendHost = "https://exp.host";
        private const string PushSendPath = "/--/api/v2/push/send";
        private const string PushGetReceiptsPath = "/--/api/v2/push/getReceipts";

        private static readonly HttpClientHandler HttpHandler = new HttpClientHandler() { MaxConnectionsPerServer = 6, UseProxy = false};
        private static readonly HttpClient HttpClient = new HttpClient(HttpHandler);

        public string AccessToken
        {
            set
            {
                HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", value);
            }
        }

        public ExpoNotificationService()
		{
            if (HttpClient.BaseAddress == null)
            {
                HttpClient.BaseAddress = new Uri(ExpoBackendHost);
                HttpClient.DefaultRequestHeaders.Accept.Clear();
                HttpClient.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
            }
        }

        public async Task<U> PostAsync<T, U>(T requestObj, string path) where T : new()
        {
            var serializedRequestObj = JsonConvert.SerializeObject(requestObj, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            var requestBody = new StringContent(serializedRequestObj, System.Text.Encoding.UTF8, "application/json");
            var responseBody = default(U);
            var response = await HttpClient.PostAsync(path, requestBody);

            if (response.IsSuccessStatusCode)
            {
                var rawResponseBody = await response.Content.ReadAsStringAsync();
                responseBody = JsonConvert.DeserializeObject<U>(rawResponseBody);
            }

            return responseBody;
        }

        public async Task<PushReceiptResponse> PushGetReceiptsAsync(PushReceiptRequest pushReceiptRequest)
        {
            var receiptResponse = await PostAsync<PushReceiptRequest, PushReceiptResponse>(pushReceiptRequest, PushGetReceiptsPath);
            return receiptResponse;
        }

        public async Task<PushTicketResponse> PushSendAsync(PushTicketRequest pushTicketRequest)
        {
            var ticketResponse = await PostAsync<PushTicketRequest, PushTicketResponse>(pushTicketRequest, PushSendPath);
            return ticketResponse;
        }

        public async Task SendNotification(List<String> receivingDeviceTokens ,String title, String body)
        {
            //create notification
            var pushTicketReq = new PushTicketRequest()
            {
                PushTo = receivingDeviceTokens,
                PushTitle = title,
                PushBody = body,
            };

            //send notification to expo server
            var result = await PushSendAsync(pushTicketReq);

            //handle error
            if (result?.PushTicketErrors?.Count() > 0)
            {
                foreach (var error in result.PushTicketErrors)
                {
                    Console.WriteLine($"Error: {error.ErrorCode} - {error.ErrorMessage}");
                }
            }
        }
    }
}

