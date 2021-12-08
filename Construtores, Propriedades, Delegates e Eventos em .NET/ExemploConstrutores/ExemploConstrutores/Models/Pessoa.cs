using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    internal class Pessoa
    {
        private readonly string nome = "Pedro";
        private readonly string sobrenome;

        public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome= sobrenome;
            Console.WriteLine("Construtor classe pessoa!");
        }

        public void Apresentar()
        {
            // Não é possivel atribuir um valor por se tratar de um campo readonly
            //this.nome = "teste";
            Console.WriteLine($"Olá, meu nome é: {nome} {sobrenome}");
        }
    }
}
