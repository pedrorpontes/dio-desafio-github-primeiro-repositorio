using System;

namespace DIO.Series
{
    internal class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            int opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario!= 7)
            {
                switch (opcaoUsuario)
                {
                    case 1:
                        ListarSeries();
                        break;
                    case 2:
                        InserirSerie();
                        break;
                    case 3:
                        AtualizarSerie();
                        break;
                    case 4:
                        ExcluirSerie();
                        break;
                    case 5:
                        VisualizarSerie();
                        break;
                    case 6:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Por favor escolha uma opção válida.");
                        return;
                }
                
                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        

        private static void ListarSeries()
        {
            var lista = repositorio.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }
            foreach(var serie in lista)
            {
                var excluido = serie.retornaExcluido();
               
                {
                    Console.WriteLine($"#ID {serie.retornaId()} - {serie.retornaTitulo()} {(excluido ? "*Excluído*" : "")}");
                }
            }
        }
        private static void InserirSerie()
        {        
            Serie novaSerie = ObterSerieUsuario();
            repositorio.Insere(novaSerie);    
            
        }
        private static void AtualizarSerie()
        {
            Console.WriteLine("Digite o id da série");
            int indiceSerie = int.Parse(Console.ReadLine());

            Serie novaSerie = ObterSerieUsuario(indiceSerie);
            
            repositorio.Atualiza(indiceSerie, novaSerie);
        }
        private static void ExcluirSerie()
        {
            Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            Console.WriteLine("Você escolheu a série: ");

            Console.ForegroundColor = ConsoleColor.Red;
            var serie = repositorio.RetornaPorID(indiceSerie);
            Console.WriteLine(serie);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Você tem certeza que deseja excluir esta série? [S/N]");

            
            bool continuar = true;

            while (continuar)
            {
                string confirmacao = Console.ReadLine().ToUpper();
                if (confirmacao == "S")
                {
                    repositorio.Exclui(indiceSerie);
                    continuar = false;
                }
                else if (confirmacao == "N")
                {
                    continuar = false;
                }
                else
                {
                    Console.WriteLine("Por favor digite 'S' ou 'N'");
                    
                }
            }

           
        }

        private static void VisualizarSerie()
        {
            Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            var serie = repositorio.RetornaPorID(indiceSerie);

            Console.WriteLine(serie);
        }

        private static int ObterOpcaoUsuario()
        {

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("DIO Séries ao seu dispor!!!");
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar série");
            Console.WriteLine("6- Limpar Tela");
            Console.WriteLine("7- Fechar o programa");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            try
            {
                int opcaoUsuario = int.Parse(Console.ReadLine());
                Console.WriteLine();
                return opcaoUsuario;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Por favor, informe um número válido");
                int opcaoUsuario = ObterOpcaoUsuario();
                return opcaoUsuario;

            }

   
        }

        private static Serie ObterSerieUsuario(int indiceSerie = -1)
        {
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            Console.WriteLine();

            
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());   
            
            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            if (indiceSerie == -1)
            {
                Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                            genero: (Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            ano: entradaAno,
                                            descricao: entradaDescricao);
                return novaSerie;
            }
            else
            {
                Serie novaSerie = new Serie(id: indiceSerie,
                                            genero: (Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            ano: entradaAno,
                                            descricao: entradaDescricao);
                return novaSerie;
            }
            

        }
    }
}
