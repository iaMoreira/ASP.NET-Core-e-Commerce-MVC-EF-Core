using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace e_commerce
{
    public interface IRelatorio
    {
        Task Imprimir(HttpContext context);
    }
}