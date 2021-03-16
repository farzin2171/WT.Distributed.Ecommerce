namespace WT.Customer.API.Infrastructure.Options
{
    public class RabbitMQOptions
    {
        public string Host { get; set; } = "localhost";

        public string Username { get; set; } = "transcode_user";

        public string Password { get; set; } = "password";

        public string QueueName { get; set; } = "customer-message";
    }
}
