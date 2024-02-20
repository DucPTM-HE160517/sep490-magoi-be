using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

namespace FR.BusinessObjects.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class PushReceiptRequest
    {
        [JsonProperty(PropertyName = "ids")]
        public List<string> PushTicketIds { get; set; }
    }
}

