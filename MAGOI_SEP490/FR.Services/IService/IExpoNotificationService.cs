using System;
using FR.BusinessObjects.Models;
using FR.BusinessObjects.Models.ExpoNotification;

namespace FR.Services.IService
{
	public interface IExpoNotificationService
	{
        public Task<PushTicketResponse> PushSendAsync(PushTicketRequest pushTicketRequest);
        public Task<PushReceiptResponse> PushGetReceiptsAsync(PushReceiptRequest pushReceiptRequest);
        public Task<U> PostAsync<T, U>(T requestObj, string path) where T : new();
    }
}

