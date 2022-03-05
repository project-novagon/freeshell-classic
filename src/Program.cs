using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Color = System.ConsoleColor;
using Figgle;

namespace freeshell
{
    public class Program
    {
        public static string? input = Console.ReadLine();

        public static void Main(string[] args)
        {   
            Console.ForegroundColor = Color.Green;
            string welcome = FiggleFonts.Standard.Render("Welcome To Freeshell!");
            System.Console.WriteLine(welcome);
            Console.Write(">");
            Console.WriteLine($"running {input}");
            // ! * BUG when i run the app, an run a command, it exits the app BUG *
            switch (input)
            {
            case "help":
                    System.Console.WriteLine("FRESHELL.NET help \n no help now");
                    Main(args);
                    break;
            case "exit":
                    Console.ForegroundColor = Color.White;
                    Environment.Exit(0);
                    Main(args);
                    break;
            case "proj":
                System.Console.WriteLine("FRESHELL.NET1 by iDev \n GH repo: https://github.com/iDevYT/freeshell \n Enjoy! ");
                break;
            default:
            	System.Console.WriteLine($"{input} Not Found. Type help for help.");
                Main(args);
                break;	
            }   
        }
    }
}