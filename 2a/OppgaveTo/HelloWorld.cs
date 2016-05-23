using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace OppgaveTo
{
    class HelloWorld : IHelloWorld
    {
   
        public Task Write(HttpContext context)
        {
            context.Response.WriteAsync("Hello World!");
            return Task.CompletedTask;
        }
    }
}