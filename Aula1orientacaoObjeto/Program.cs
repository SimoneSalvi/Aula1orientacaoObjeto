using System.Globalization;

internal class Program
{

    private static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa();
        p1.SetPessoa("João");
        p1.SetSobrenome("da Silva");
        // p1.NomeInteiro(p1.GetNome(), p1.GetSobrenome());
        Console.WriteLine(p1.NomeInteiro2());

        // p1.idade = 27;
        p1.altura = 1.79;
        p1.SetDataNasc(DateTime.Parse("31/12/1990"));

        // p1.NomeInteiro();
        // p1.ImprimePessoa(p1);
    }

    public class Pessoa
    {
        //atributos
        private string nome;
        private string sobrenome;
        private DateTime dataNasc;
        //       public int idade { get; set; }
        public double altura { get; set; }


        // metodo construtor
        public Pessoa() { }

        //metodos get e set
        public void SetPessoa(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public void SetSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }

        public string GetSobrenome()
        {
            return this.sobrenome;
        }

        public void SetDataNasc(DateTime dataNasc)
        {
            this.dataNasc = dataNasc;
        }

        public DateTime GetDataNasc()
        {
            return this.dataNasc;
        }

        //metodo imprime
        public void ImprimePessoa(Pessoa pessoa)
        {
            Console.WriteLine($"Nome da pessoa é {this.GetNome()}");
            Console.WriteLine($"Data de nascimento é {this.GetDataNasc()}");
            Console.WriteLine($"altura é {this.altura}");


        }

        //metodo nome inteiro
        public void NomeInteiro(string nome, string sobrenome)
        {
            Console.WriteLine($"Nome inteiro: {nome} {sobrenome}");
        }

        //metodo nome inteiro
        public string NomeInteiro2()
        {
            string nomeInteiro = "";
            nomeInteiro = nome + " " + sobrenome;
            return nomeInteiro;
        }

    }

}