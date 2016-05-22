using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;


namespace _2a
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var webhost = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();

            webhost.Run();

        }
    }
}
