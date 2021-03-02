using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AccountingMetrics
{
    internal class Data
    {
        [JsonProperty("object_category")]

        public string ObjectCategory { get; set; }

        [JsonProperty("connection_id")]

        public string ConnectionId { get; set; }
        public string User { get; set; }

        [JsonProperty("object_creation_date")]
        public string OjectCreationDate { get; set; }

        [JsonProperty("data")]
        public IList<Account> Accounts { get; set; }
        public string Currency { get; set; }

        [JsonProperty("object_origin_type")]
        public string ObjectOriginType { get; set; }

        [JsonProperty("object_origin_category")]
        public string ObjectOriginCategory { get; set; }

        [JsonProperty("object_type")]
        public string ObjectType { get; set; }

        [JsonProperty("object_class")]
        public string ObjectClass { get; set; }

        [JsonProperty("balance_date")]
        public DateTime BalanceDate { get; set; }
    }
}