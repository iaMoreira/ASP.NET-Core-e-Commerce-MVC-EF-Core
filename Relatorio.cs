using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace e_commerce
{
    public class Relatorio
    {
        public Relatorio(Catalogo catalogo)
        {
        this.catalogo = catalogo;
        }
        private readonly Catalogo catalogo;

        public async Task Imprimir(HttpContext context)
        {
            foreach (var livro in catalogo.GetLivros())
            {
                await context.Response.WriteAsync($"{livro.Codigo, -10} {livro.Nome, -40} {livro.Preco.ToString("C"), 10}\r\n");
            }
        }

    }
}