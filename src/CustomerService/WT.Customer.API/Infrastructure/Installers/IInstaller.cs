using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WT.Customer.API.Infrastructure.Installers
{
    public interface IInstaller
    {
        void InstallServices(IServiceCollection services, IConfiguration configuration);
    }
}
