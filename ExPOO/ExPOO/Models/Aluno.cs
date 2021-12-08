namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }


        public Aluno(string nome, int idade, double nota) : base(nome, idade)
        {
            Nota = nota;
        }

        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome} e sou um aluno nota {Nota}");
        }
    }
}
