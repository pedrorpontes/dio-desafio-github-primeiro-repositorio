using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    internal class Calculadora
    {
        //Delegate
        public delegate void DelegateCalculadora();

        public static event DelegateCalculadora EventoCalculadora;

        public static void Somar(int x, int y)
        {
            if (EventoCalculadora != null) 
            { 
            Console.WriteLine($"Adição: {x + y}");
                EventoCalculadora();
            }
            else
            {
                Console.WriteLine("Nenhum inscrito");
            }

        }

        public static void Subtrair(int x, int y)
        {
            Console.WriteLine($"Subtração: {x - y}");
        }

    }
}
