namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderBillingOptions : INestedOptions
    {
        [JsonProperty("address")]
        public CardholderBillingAddressOptions Address { get; set; }
    }
}
