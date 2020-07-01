namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SetupIntentConfirmOptions : BaseOptions
    {
        [JsonProperty("mandate_data")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<SetupIntentMandateData1Options, SetupIntentMandateData2Options> MandateData { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("payment_method_options")]
        public SetupIntentPaymentMethodOptionsOptions PaymentMethodOptions { get; set; }

        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }
    }
}
