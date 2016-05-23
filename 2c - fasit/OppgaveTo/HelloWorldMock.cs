using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace OppgaveTo
{
    class HelloWorldMock : IHelloWorld
    {
   
        public Task Write(HttpContext context)
        {
            context.Response.WriteAsync("Hello Mock!");
            return Task.CompletedTask;
        }
    }
}