namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentNextAction : StripeEntity<PaymentIntentNextAction>
    {
        [JsonProperty("redirect_to_url")]
        public PaymentIntentNextActionRedirectToUrl RedirectToUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("use_stripe_sdk")]
        public PaymentIntentNextActionUseStripeSdk UseStripeSdk { get; set; }
    }
}
