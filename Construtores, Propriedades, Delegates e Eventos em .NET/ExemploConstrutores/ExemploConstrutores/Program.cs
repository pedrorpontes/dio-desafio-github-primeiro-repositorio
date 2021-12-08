using ExemploConstrutores.Models;
using System;
using System.Globalization;

namespace ExemploConstrutores
{
    internal class Program
    {
        public delegate void Operacao(int x, int y);

        static void Main(string[] args)
        {
            Matematica m = new Matematica(10, 20);
            m.Somar();
            
            
            //Operacao op = Calculadora.Somar;
            //Operacao op = new Operacao(Calculadora.Somar);
            //op += Calculadora.Subtrair;

            //op.Invoke(10, 10);

            //op(10, 10);


            //const double pi = 3.14;
            // Formatar texto para duas casas decimais
            //Console.WriteLine(pi.ToString("F2", CultureInfo.InvariantCulture));

            // Valor de uma constante só pode ser atribuido em sua inicialização
            //pi = 0;
            
            
            
            //Data data = new Data();
            //data.SetMes(20);

            //data.Mes = 20;

            //data.ApresentarMes();
            
            
            //Log log = Log.GetInstance();

            //log.PropriedadeLog = "Teste instancia";

            //Log log2 = Log.GetInstance();
            //Console.WriteLine(log2.PropriedadeLog);

            
            //Aluno p1 = new Aluno("Pedro", "Pontes", "Matemática");
           //p1.Apresentar();
        }

    }
}
