using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace OppgaveTo.Controllers
{
    [Route("hello")]
    public class HelloController : Controller
    {
        private readonly string _message;

        public HelloController(IOptions<HelloOptions> options)
        {
            _message = options.Value.HelloMessage;
        }

        [Route("world")]
        public JsonResult World()
        {
            return new JsonResult(new
            {
                Headline = "Hello from controller",
                Message = _message
            });
        }

    }
}
