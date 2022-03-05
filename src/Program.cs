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

        public static void Main(string[] args)
        {   
            Console.ForegroundColor = Color.Green;
            string welcome = FiggleFonts.Standard.Render("Welcome To Freeshell!");
            Console.Write(">");
            System.Console.WriteLine(welcome);
            string? input = Console.ReadLine();
            Console.WriteLine($"running {input}");
            bool commands = true;
            while (commands == true) 
            {
            switch (input)
                {
                 case "help":
                    System.Console.WriteLine("FRESHELL.NET help \n no help now");
                commands = false;
                    break;
                case "exit":
                    Console.ForegroundColor = Color.White;
                    Environment.Exit(0);
                    commands = false; 
                    break;
                case "proj":
                System.Console.WriteLine("FRESHELL.NET1 by iDev \n GH repo: https://github.com/iDevYT/freeshell \n Enjoy! ");
                commands = false;
                break;
                default:
            	System.Console.WriteLine($"{input} Not Found. Type help for help.");
                commands = false;
                break;	
            }   
            }           
        }
    }
}