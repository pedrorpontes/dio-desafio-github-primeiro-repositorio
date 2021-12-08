using System;
using System.Collections.Generic;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            string caminho = "C:\\Workspace\\dio-desafio-github-primeiro-repositorio\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");

            var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
            var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };
            

            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);
            //helper.CriarDiretorio(caminhoPathCombine);
            //helper.ApagarDiretorio(caminhoPathCombine, true);
            //helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo");
            //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            //helper.LerArquivoStream(caminhoArquivo);
            //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);


            
            //ICalculadora calc = new Calculadora();
            //Console.WriteLine(calc.Somar(10, 20));

            
            //Corrente c = new Corrente();
            //c.Creditar(100);
            //c.Creditar(100);
            //c.Creditar(100);
            //c.ExibirSaldo();
            
            //Calculadora calc = new Calculadora();
            //Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10,10));
            //Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 10));



            //Professor p1 = new Professor();

            //p1.Nome = "Bob";
            //p1.Salario = 2000;
            //p1.Idade = 20;
            //p1.Documento = "7451523";

            //p1.Apresentar();

            //Aluno a1 = new Aluno("Chad", 27, 7.5);
            //a1.Apresentar();



            //// Valores válidos
            //Retangulo r1 = new Retangulo();
            //r1.DefinirMedidas(30, 30);
            //Console.WriteLine($"Área: {r1.ObterArea()}");

            //// Valores inválidos
            //Retangulo r2 = new Retangulo();
            //r2.DefinirMedidas(-30, 30);
            //Console.WriteLine($"Área: {r2.ObterArea()}");

            //Pessoa p1 = new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p1.Apresentar();


        }
    }
}
