namespace Stripe
{
    using Newtonsoft.Json;

    public class EventData : StripeEntity<EventData>, IHasObject
    {
        [JsonProperty("object")]
        public EventDataObject Object { get; set; }

        [JsonProperty("previous_attributes")]
        public EventDataPreviousAttributes PreviousAttributes { get; set; }
    }
}
