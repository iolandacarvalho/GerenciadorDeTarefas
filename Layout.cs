namespace Layout
{
    class Formatacao
    {
        public static void ImprimirCabecalho()
        {
            Console.WriteLine("╔═════════════════════════════════╗");
            Console.WriteLine("║      GERENCIADOR DE TAREFAS     ║");
            Console.WriteLine("╚═════════════════════════════════╝");

            Console.WriteLine("\n1 - Adicionar Tarefa");
            Console.WriteLine("2 - Listar Tarefas");
            Console.WriteLine("3 - Concluir Tarefa");
            Console.WriteLine("4 - Remover Tarefa");
            Console.WriteLine("0 - Sair\n");
            Console.WriteLine("Escolha uma opção: ");
        }

        public static void Cor(string texto, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(texto);
            Console.ResetColor();
        }
    }
}