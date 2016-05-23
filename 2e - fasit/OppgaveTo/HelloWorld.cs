using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace OppgaveTo
{
    class HelloWorld : IHelloWorld
    {

        private readonly string _message;

        public HelloWorld(IOptions<HelloOptions> options)
        {
            _message = options.Value.HelloMessage;
        }


        public Task Write(HttpContext context)
        {
            context.Response.WriteAsync(_message);
            return Task.CompletedTask;
        }
    }
}