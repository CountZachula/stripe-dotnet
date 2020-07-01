namespace Stripe
{
    using Newtonsoft.Json;

    public class SessionLineItemPriceDataRecurringOptions : INestedOptions
    {
        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("interval_count")]
        public long? IntervalCount { get; set; }
    }
}
