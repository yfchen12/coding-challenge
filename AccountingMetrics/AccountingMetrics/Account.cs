using Newtonsoft.Json;

namespace AccountingMetrics
{
    public class Account
    {
        [JsonProperty("account_category")]
        public string AccountCategory { get; set; }

        [JsonProperty("account_code")]
        public int AccountCode { get; set; }

        [JsonProperty("account_currency")]
        public string AccountCurrency { get; set; }

        [JsonProperty("account_identifier")]
        public string AccountIdentifier { get; set; }

        [JsonProperty("account_status")]
        public string AccountStatus { get; set; }

        [JsonProperty("value_type")]
        public string ValueType { get; set; }

        [JsonProperty("account_name")]
        public string AccountName { get; set; }

        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        [JsonProperty("account_type_bank")]
        public string AccountTypeBank { get; set; }

        [JsonProperty("system_account")]
        public string SystemAccount { get; set; }

        [JsonProperty("total_value")]
        public float TotalValue { get; set; }
    }
}