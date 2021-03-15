namespace WT.Customer.API.Infrastructure.Options
{
    public class ServiceBusConfigurationOption
    {
        public MessageQueueProvider Provider { get; set; }

        public AzureServiceBusOptions AzureServiceBus { get; set; }

        public RabbitMQOptions RabbitMQ { get; set; }
    }
}
