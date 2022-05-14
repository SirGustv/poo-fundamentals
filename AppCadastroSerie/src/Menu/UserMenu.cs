using System;

namespace AppCadastroSerie.Menu
{
    class UserMenu
    {
        public static void CallMenu()
        {
            UserOptions();
        }

        private static void UserOptions()
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
        }
    }
}