using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace e_commerce
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                var livros  = new List<Livro>();
                livros.Add(new Livro("001", "Quem mexeu na minha query?", 12.99m));
                livros.Add(new Livro("002", "Fique Rico com C#", 30.99m));
                livros.Add(new Livro("003", "Java Para Baixinhos", 25.99m));

                endpoints.MapGet("/", async context =>
                {
                    foreach (var livro in livros)
                    {
                        await context.Response.WriteAsync($"{livro.Codigo, -10} {livro.Nome, -40} {livro.Preco.ToString("C"), 10}\r\n");
                    }
                });
            });
        }
    }
}
