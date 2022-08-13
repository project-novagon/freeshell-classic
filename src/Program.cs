using freeshell.api.commands;
using System.Diagnostics;
using Color = System.ConsoleColor;
using Figgle;

namespace freeshell
{
    public class Program
    {

        public static void Main(string[] args)
        {
            string? input = Console.ReadLine();
            freeshell.api.commandInterfacec.commandListen(input);
        }
    }
}