using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace OppgaveTo
{
    public class Startup
    {
        private readonly IHostingEnvironment _env;


        public Startup(IHostingEnvironment env)
        {
            _env = env;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            if (_env.IsDevelopment())
            {
                services.AddTransient<IHelloWorld, HelloWorldMock>();
            }
            else
            {
                services.AddTransient<IHelloWorld, HelloWorld>();
            }
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