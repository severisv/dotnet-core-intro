using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace OppgaveTo
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IHelloWorld, HelloWorld>();
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