using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WT.Customer.API.Infrastructure.Extentions;
using WT.Customer.API.Infrastructure.StartupTasks;
using WT.Customer.Data.Databse;
using WT.Customer.Data.Repositories;
using WT.Customer.Services.Customer;

namespace WT.Customer.API.Infrastructure.Installers
{
    public class DbInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlServer(
                   configuration.GetConnectionString("DefaultConnection")));
           

            services.AddStartupTask<InformationStartupTask>();
            services.AddScoped<ICustomerInformationRepository, CustomerInformationRepository>();
            services.AddScoped<ICustomerInformationService, CustomerInformationService>();
            //services.AddScoped<IIdentityService, IdentityService>();
            //services.AddScoped<ICustomerInformationService, CustomerInformationService>();
            //services.AddScoped<IGenerateOrderRefrence, GenerateOrderRefrence>();
            //services.AddScoped<IOrderService, OrderService>();
            //services.AddScoped<IDriverService, DriverService>();

            //services.Decorate<ILocationService, LocationServiceSendMessage>();

            //services.AddHostedService<MessageBrokerPubSubWorker>();
        }
    }
}
