﻿using System;
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
            
            string welcome = FiggleFonts.Standard.Render("Welcome To Freeshell!");
            Console.WriteLine(welcome);
            bool commands = true;
            while (commands)
            {
                Console.ForegroundColor = Color.Green;
                Console.Write(">");
                string? input = Console.ReadLine();
                Console.WriteLine($"running {input}");
                switch (input)
                {
                    case "help":
                        Console.WriteLine("FRESHELL.NET help \n proj: shows the project link \n exit: exits the program \n figlet: make a text to ascii text. \n clcon: clears the console \n Thanks");
                        break;
                    case "exit":
                        Console.ForegroundColor = Color.White;
                        Console.WriteLine("Bye!");
                        commands = false;
                        break;
                    case "proj":
                        Console.WriteLine("FRESHELL.NET1 by iDev \n GH repo: https://github.com/iDevYT/freeshell \n Enjoy! ");
                        break;
                    case "figlet":
                        figlet.Run(input);
                        break;
                    case "clcon":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine($"{input} Not Found. Type help for help.");
                        break;
                }
            }
        }
    }
}