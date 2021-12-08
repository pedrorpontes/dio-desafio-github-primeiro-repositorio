using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    internal class Aluno : Pessoa
    {
        public Aluno(string nome, string sobrenome, string aluno) : base(nome, sobrenome)
        {
            Console.WriteLine("Construtor classe aluno!");
        }
    }
}
