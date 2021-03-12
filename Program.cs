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
            string nomeCompletoo;
            string sobrenocompleto;
            string Nomedecatalogo;
            string nomedecatalogo2;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Digite seu primeiro nome: ");

            Console.ForegroundColor = ConsoleColor.White;
            nome = Console.ReadLine();
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Digite seu sobrenome: ");

            Console.ForegroundColor = ConsoleColor.White;
            sobrenome = Console.ReadLine();
            
            Console.ForegroundColor = ConsoleColor.White;
            nomeCompletoo = nome;
            sobrenocompleto = sobrenome;

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Nome completo: ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{nomeCompletoo} {sobrenocompleto}");

            Nomedecatalogo = sobrenome;
            nomedecatalogo2 = nome;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Nome de catálogo: ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{Nomedecatalogo.ToUpper()}, {nomedecatalogo2}");
            
            Console.ResetColor();
            Console.Beep();

        }
    }
}
