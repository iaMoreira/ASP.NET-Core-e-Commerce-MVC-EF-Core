using System.Collections.Generic;

namespace e_commerce
{
    public class Catalogo
    {
        public List<Livro> GetLivros(){
            var livros  = new List<Livro>();
            livros.Add(new Livro("001", "Quem mexeu na minha query?", 12.99m));
            livros.Add(new Livro("002", "Fique Rico com C#", 30.99m));
            livros.Add(new Livro("003", "Java Para Baixinhos", 25.99m));
        
            return livros;
        }   
    }
}