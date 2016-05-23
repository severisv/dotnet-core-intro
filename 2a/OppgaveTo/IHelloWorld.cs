using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace OppgaveTo
{
    public interface IHelloWorld
    {
        Task Write(HttpContext context);
    }
}