using Microsoft.Extensions.DependencyInjection;
using WT.Customer.API.Infrastructure.StartupTasks;

namespace WT.Customer.API.Infrastructure.Extentions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddStartupTask<T>(this IServiceCollection services) where T : class, IStartupTask => services.AddTransient<IStartupTask, T>();
    }
}
