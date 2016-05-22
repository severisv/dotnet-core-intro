using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace _2a
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }

    }
}