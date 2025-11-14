namespace PrimeiraClasse
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
        public int Altura;//em centímetros

        public void Falar()
        {
            Console.WriteLine($"Olá, eu sou {Nome} e tenho {Idade} anos!");
        }
        public void Dormir()
        {
            Console.WriteLine($"ZZZzzzz ...");
        }

        public void Envelhecer(int _id = 0)
        {
            if (_id > 0)
            {
                Idade++;
            }
            else
            {
                
            }     
        }
// criar um objeto da classe Pessoa
// preencher as propriedades da classe Pessoa
// rodar os métodos da classe pessoa, parecido com o que fizemos na classe
// Carro
    }
}