using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace OppgaveTo
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }


        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            Configuration = builder.Build();

    }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IHelloWorld, HelloWorld>();
            services.Configure<HelloOptions>(Configuration.GetSection("Hello:World"));
        }

        public void Configure(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                var helloWorld = context.RequestServices.GetService<IHelloWorld>();
                await helloWorld.Write(context);
            });
        }
    }
}