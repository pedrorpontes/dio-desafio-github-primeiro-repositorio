using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes.Helper
{
    internal class OperacoesLista
    {
        public void ImprimirListaString(List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"Índice {i}, Valor {lista[i]}");

            }
        }
    }
}
