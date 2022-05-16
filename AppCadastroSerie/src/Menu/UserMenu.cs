using System;
using AppCadastroSerie.Classes;

namespace AppCadastroSerie.Menu
{
    class UserMenu
    {
        static SerieRepository repositorio = new SerieRepository();
        public static void CallMenu()
        {
            string userOption = GetUserOptions();
            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        ListSeries();
                        break;
                    case "2":
                        InsertSerie();
                        break;
                    case "3":
                        UpdateSerie();
                        break;
                    case "4":
                        ViewSeries();
                        break;
                    case "5":
                        ExcludeSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                userOption = GetUserOptions();
            }
            Console.WriteLine("Obrigado por usar nosso serviço! Aperte qualquer tecla para sair.");
            Console.ReadKey();

        }

        private static void ViewSeries()
        {
            Console.WriteLine("\nDigite o ID da série a ser visualizada");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.ReturnById(indiceSerie);
            Console.WriteLine(serie);
            CallMenu();
        }

        private static void ExcludeSerie()
        {
            Console.WriteLine("\nDigite o ID da série a ser excluida");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Exclude(indiceSerie);
            CallMenu();
        }
        private static void UpdateSerie()
        {
            Console.WriteLine("Digite o ID da série a ser atualizada");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genre), i));
            }

            Console.Write("\nDigite o gênero entre as opções acima: ");
            int entryGenre = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string entryTitle = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entryYear = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entryDescription = Console.ReadLine();

            Series atualizaSerie = new Series(id: indiceSerie,
                                        genre: (Genre)entryGenre,
                                        title: entryTitle,
                                        year: entryYear,
                                        description: entryDescription);

            repositorio.Update(indiceSerie, atualizaSerie);

            CallMenu();
        }

        private static void InsertSerie()
        {
            Console.WriteLine("Insira uma nova série");

            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genre), i));
            }

            Console.Write("\nDigite o gênero entre as opções acima: ");
            int entryGenre = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string entryTitle = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entryYear = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entryDescription = Console.ReadLine();

            Series novaSerie = new Series(id: repositorio.NextId(),
                                        genre: (Genre)entryGenre,
                                        title: entryTitle,
                                        year: entryYear,
                                        description: entryDescription);

            repositorio.Insert(novaSerie);

            CallMenu();
        }

        private static void ListSeries()
        {
            Console.WriteLine("Lista de Séries");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série encontrada.");
            }
            foreach (var serie in lista)
            {
                var exclude = serie.returnExclude();

                Console.WriteLine("#ID {0}: - {1} - {2} ", serie.returnId(), serie.returnTitle(), (exclude ? "*Excluido*" : ""));
            }
            CallMenu();
        }

        private static string GetUserOptions()
        {
            Console.WriteLine();
            Console.WriteLine("Bem Vindo ao sistema de séries Code");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("\n1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Visualizar série");
            Console.WriteLine("5 - Excluir série");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair\n");

            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userOption;
        }
    }
}