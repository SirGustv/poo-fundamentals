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
                }
            }
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
                Console.WriteLine("#ID {0}: - {1} ", serie.returnId(), serie.returnTitle());
            }

        }

        private static string GetUserOptions()
        {
            Console.Clear();

            Console.WriteLine("Bem Vindo ao sistema de séries Code");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("\n1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Visualizar série");
            Console.WriteLine("5 - Excluir série");
            Console.WriteLine("X - Sair");

            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userOption;
        }
    }
}