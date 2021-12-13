using Colecoes.Helper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Colecoes
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[10] { 100, 1, 4, 0, 8, 15, 19, 19, 4, 100};

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distinct().ToArray();

            Console.WriteLine($"Mínimo: {minimo}");
            Console.WriteLine($"Máximo: {maximo}");
            Console.WriteLine($"Médio: {medio}");
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Array original: {string.Join(", ", arrayNumeros)}");
            Console.WriteLine($"Array distinto: {string.Join(", ", arrayUnico)}");




            //var numerosParesQuery =
            //   from num in arrayNumeros
            //   where num % 2 == 0
            //   orderby num
            //   select num;

            //var numerosParesMetodo = arrayNumeros.Where(x => x%2 == 0).OrderBy(x => x).ToList();

            //Console.WriteLine("Números pares query: " + string.Join(", ", numerosParesQuery));
            //Console.WriteLine("Números pares método: " + string.Join(", ", numerosParesMetodo));

            //Dictionary<string, string> estados = new Dictionary<string, string>();
            //estados.Add("SP", "São Paulo");
            //estados.Add("MG", "Minas Gerais");
            //estados.Add("BA", "Bahia");


            //foreach (var item in estados)
            //{
            //    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            //}

            //string valorProcurado = "SC";
            ////var teste = estados["SC"];


            //if (estados.TryGetValue(valorProcurado, out string estadoEncontrado))
            //{
            //    Console.WriteLine(estadoEncontrado);
            //}
            //else
            //{
            //    Console.WriteLine($"Chave {valorProcurado} não existe no dicionário");
            //}

            //Console.WriteLine($"Removendo o valor: {valorProcurado}");
            //estados.Remove(valorProcurado);

            //foreach (var item in estados)
            //{
            //    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            //}

            //Console.WriteLine("Valor original: ");
            //Console.WriteLine(estados[valorProcurado]);

            //estados[valorProcurado] = "BA - teste atualização";
            //Console.WriteLine("Valor atualizado: ");
            //Console.WriteLine(estados[valorProcurado]);


            //Stack<string> pilhaLivros = new Stack<string>();
            //pilhaLivros.Push(".NET");
            //pilhaLivros.Push("DDD");
            //pilhaLivros.Push("Código limpo");


            //Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");
            //while (pilhaLivros.Count > 0)
            //{
            //    Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}");
            //    Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
            //}
            //Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");


            //Queue<string> fila = new Queue<string>();

            //fila.Enqueue("Leonardo");
            //fila.Enqueue("Eduardo");
            //fila.Enqueue("André");

            //while (fila.Count > 0)
            //{
            //    Console.WriteLine($"Vez de : {fila.Peek()}");
            //    Console.WriteLine($"{fila.Dequeue()} atendido");
            //}
            //Console.WriteLine($"Pessoas na fila: {fila.Count}");


            //OperacoesLista opLista = new OperacoesLista();
            //List<string> estados = new List<string>() { "SP", "MG", "BA"};
            //string[] estadosArray = new string[2] {"SC", "MT"};



            //Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

            //opLista.ImprimirListaString(estados);

            //Console.WriteLine("Removendo o elemento");

            //estados.Remove("MG");

            //estados.AddRange(estadosArray);
            //estados.Insert(1, "RJ");

            //opLista.ImprimirListaString(estados);


            //OperacoesArray op = new OperacoesArray();
            //int[] array = new int[5] { 6, 3, 8, 1, 9};
            //int[] arrayCopia = new int[10];
            //string[] arrayString = op.ConverterParaArrayString(array);


            ////int valorProcurado = 9;

            //Console.WriteLine("Capacidade atual do array: " + array.Length);

            //op.RedimensionarArray(ref array, array.Length * 2);

            //Console.WriteLine("Capacidade do array após redimensionar: " + array.Length);


            //int indice = op.ObterIndice(array, valorProcurado);

            //if (indice > -1)
            //{
            //    Console.WriteLine($"O índice do elemento {valorProcurado} é: {indice}");
            //}
            //else
            //{
            //    Console.WriteLine("Valor não existente no array");
            //}

            //int valorAchado = op.ObterValor(array, valorProcurado);
            //Console.WriteLine(valorAchado);

            //if(valorAchado > 0)
            //{
            //    Console.WriteLine("Encontrei o valor");
            //}
            //else
            //{
            //    Console.WriteLine("Não encontrei o valor");
            //}



            //bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

            //if (todosMaiorQue)
            //{
            //    Console.WriteLine("Todos os valores são maior ou igual a {0}", valorProcurado);
            //}
            //else
            //{
            //    Console.WriteLine("Existe valores que não são maiores do que {0}", valorProcurado);
            //}



            //bool existe = op.Existe(array, valorProcurado);
            //if (existe)
            //{
            //    Console.WriteLine($"Encontrei o valor: {valorProcurado}");
            //}
            //else
            //{
            //    Console.WriteLine($"Não encontrei o valor: {valorProcurado}");
            //}

            //Console.WriteLine("Array original: ");
            //op.ImprimirArray(array);

            //op.OrdenarBubbleSort(ref array);
            //op.Ordenar(ref array);

            //Console.WriteLine("Array ordenado: ");
            //op.ImprimirArray(array);


            //Console.WriteLine("Array antes da cópia:");
            //op.ImprimirArray(arrayCopia);
            //op.Copiar(ref array, ref arrayCopia);
            //Console.WriteLine("Array após a cópia:");
            //op.ImprimirArray(arrayCopia);

            //int[,] matriz = new int[4, 2]
            //{
            //    {8, 8},
            //    {10, 20},
            //    {50, 100},
            //    {90, 200}
            //};

            //for(int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for(int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        if (j != (matriz.GetLength(1) - 1))
            //            Console.Write(matriz[i, j] + ",");
            //        else
            //            Console.WriteLine(matriz[i, j]);
            //    }

            //}

            //int[] arrayInteiros = new int[3];
            //arrayInteiros[0] = 10;
            //arrayInteiros[1] = 20;
            //arrayInteiros[2] = int.Parse("30");


            //arrayInteiros[3] = 30;

            //Console.WriteLine("Percorrendo array pelo For: ");
            //for(int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(arrayInteiros[i]);
            //}

            //Console.WriteLine("Percorrendo o array pelo ForEach: ");

            //foreach (int i in arrayInteiros)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}
