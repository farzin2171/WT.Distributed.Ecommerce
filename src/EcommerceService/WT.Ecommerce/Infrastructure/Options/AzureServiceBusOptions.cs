namespace WT.Customer.API.Infrastructure.Options
{
    public class AzureServiceBusOptions
    {
        public string Host { get; set; }

        public string SharedAccessKeyName { get; set; }

        public string SharedAccessKey { get; set; }

        public string TopicPath { get; set; } = "customer-message";

        public string SubscriptionName { get; set; } = "customer-service";
    }
}
