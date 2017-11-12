///
/// tutorial : https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-view
/// now at step: https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model
/// publishing via heroku : http://codersblock.com/blog/how-to-run-net-on-heroku/ (use 'git bash' as CLI !)

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace app.web.mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder().AddCommandLine(args).Build();
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseConfiguration(config)
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
