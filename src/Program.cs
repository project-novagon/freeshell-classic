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
            switch (input)
            {
            case "help":
                    System.Console.WriteLine("FRESHELL.NET help \n no help now");
                    break;
            case "exit":
                    Console.ForegroundColor = Color.White;
                    Environment.Exit(0);
                    break;
            case "proj":
                System.Console.WriteLine("FRESHELL.NET1 by iDev \n GH repo: https://github.com/iDevYT/freeshell \n Enjoy! ");
                break;
            default:
            	System.Console.WriteLine("Unknown command. Type help for help.");
                break;	
            }   
        }
    }
}