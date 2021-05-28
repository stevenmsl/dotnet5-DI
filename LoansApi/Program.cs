using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac.Extensions.DependencyInjection;

namespace LoansApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                /* #REF02, #TA01
                  - allows for ConfigureContainer to be supported
                    in Startup with a strongly-typed ContainerBuilder
                    - #REF01
                  - if you don't do this, you can't use ContainerBuilder
                    in Startup to register Autofac modules
                  - automatically calls Populate to put services 
                    you register during ConfgiureServices into AutoFac
                */
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
