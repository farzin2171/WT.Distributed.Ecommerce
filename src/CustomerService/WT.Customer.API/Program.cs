using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using WT.Customer.API.Infrastructure.Extentions;

namespace WT.Customer.API
{
    public class Program
    {
        public static void Main(string[] args) => BuildWebHost(args).RunTasks().Run();

        public static IHost BuildWebHost(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); })
                .ConfigureLogger()
                .Build();
    }
}
