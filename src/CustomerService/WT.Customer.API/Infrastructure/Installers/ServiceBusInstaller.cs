using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using WT.Customer.API.Infrastructure.Options;

namespace WT.Customer.API.Infrastructure.Installers
{
    public class ServiceBusInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {

			var serviceBusConfigurationOption = new ServiceBusConfigurationOption();
			configuration.Bind("ServiceBus", serviceBusConfigurationOption);
			services.AddSingleton(serviceBusConfigurationOption);

			static IBusControl CreateBus(IServiceProvider serviceProvider)
			{
				var options = serviceProvider.GetService<ServiceBusConfigurationOption>();

				return CreateRabbitMQBus(serviceProvider, options.RabbitMQ);
			}

			static IBusControl CreateRabbitMQBus(IServiceProvider serviceProvider, RabbitMQOptions options)
			{
				return Bus.Factory.CreateUsingRabbitMq(cfg =>
				{
					cfg.Host($"rabbitmq://{options.Host}", host =>
					{
						host.Username(options.Username);
						host.Password(options.Password);
					});

					//cfg.ReceiveEndpoint(options.QueueName, ep =>
					//{
					//	ep.Consumer<AuditMessageConsumer>(serviceProvider);
					//});


				});
			}

			services.AddMassTransit(configurator =>
			{
				//configurator.AddConsumer<AuditMessageConsumer>();

				configurator.AddBus(CreateBus);

			});

			services.AddMassTransitHostedService();

		}

		
	}
}
