using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep();
            Console.Clear();

            string nome;
            string sobrenome;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Digite seu primeiro nome: ");

            Console.ForegroundColor = ConsoleColor.White;
            nome = Console.ReadLine();
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Digite seu sobrenome: ");

            Console.ForegroundColor = ConsoleColor.White;
            sobrenome = Console.ReadLine();
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Nome completo: ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{nome} {sobrenome}");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Nome de catálogo: ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{sobrenome.ToUpper()}, {nome}");
            
            Console.ResetColor();
            Console.Beep();
        }
    }
}
