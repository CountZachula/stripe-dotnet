namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountSettingsPayoutsScheduleOptions : INestedOptions
    {
        [JsonProperty("delay_days")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<long?, string> DelayDays { get; set; }

        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("monthly_anchor")]
        public long? MonthlyAnchor { get; set; }

        [JsonProperty("weekly_anchor")]
        public string WeeklyAnchor { get; set; }
    }
}
