using Filme;
namespace Filme
{
    public class Filme
    {
        public string Titulo;
        public string Genero;
        public int Duracao;

        public Filme()
        {
            System.Console.WriteLine("Lista de filmes:");
        }
  
        public Filme(string t, string g, int d)
        {
            Titulo = t;
            Genero = g;
            Duracao = d;
        }

        public void ExibirDados()
        {
            System.Console.WriteLine($"Filme: {Titulo} | Gênero: {Genero} | Duração: {Duracao} minutos");
        }
    }
}
