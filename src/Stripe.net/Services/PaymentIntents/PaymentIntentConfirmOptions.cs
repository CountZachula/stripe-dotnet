namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentConfirmOptions : BaseOptions
    {
        [JsonProperty("error_on_requires_action")]
        public bool? ErrorOnRequiresAction { get; set; }

        [JsonProperty("mandate")]
        public string Mandate { get; set; }

        [JsonProperty("mandate_data")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<PaymentIntentMandateData1Options, PaymentIntentMandateData2Options> MandateData { get; set; }

        [JsonProperty("off_session")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<bool?, string> OffSession { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("payment_method_data")]
        public PaymentIntentPaymentMethodDataOptions PaymentMethodData { get; set; }

        [JsonProperty("payment_method_options")]
        public PaymentIntentPaymentMethodOptionsOptions PaymentMethodOptions { get; set; }

        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        [JsonProperty("save_payment_method")]
        public bool? SavePaymentMethod { get; set; }

        [JsonProperty("setup_future_usage")]
        public string SetupFutureUsage { get; set; }

        [JsonProperty("shipping")]
        public ShippingOptions Shipping { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("use_stripe_sdk")]
        public bool? UseStripeSdk { get; set; }
    }
}
