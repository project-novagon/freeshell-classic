﻿using System.Diagnostics;
using Color = System.ConsoleColor;
using Figgle;
using System;

namespace freeshell
{
    public class Program
    {

        public static void Main(string[] args)
        {
            ProgramInfo progInfo = new ProgramInfo();
            string welcome = FiggleFonts.Standard.Render("Welcome To Freeshell!");
            Console.WriteLine(welcome);
            progInfo.PrintInfo();
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
                        Console.WriteLine("FRESHELL.NET help \n about: shows the project link \n exit: exits the program \n figlet: make a text to ascii text. \n clcon: clears the console \n the project is built with c# and .NET\n Thanks");
                        break;
                    case "exit":
                        Console.ForegroundColor = Color.White;
                        Console.WriteLine("Bye!");
                        commands = false;
                        break;
                    case "about":
                        Console.WriteLine($"{progInfo.VersionName} version {progInfo.VersionNumber} by {progInfo.Author} \n GH repo: https://github.com/iDevYT/freeshell \n Enjoy! ");
                        break;
                    case "figlet":
                        figlet.Run(input);
                        break;
                    case "clcon":
                        Console.Clear();
                        progInfo.PrintInfo();
                        break;
                    case "hello":
                        System.Console.WriteLine("Hello World!"); 
                        break;
                    case "reload":
                        System.Console.WriteLine("Reloading...");
                        Console.WriteLine(welcome);
                        break;
                    case "color":
                        Console.WriteLine("color: ");
                        break;
                    default:
                        Console.WriteLine($"{input} Not Found. Type help for help.");
                        break;
                }
            }
        }
    }

    public class ProgramInfo{
        public double VersionNumber { get; set; }
        public string VersionName { get; set; }
        public string Author { get; set; }



        public ProgramInfo(){
            VersionNumber = 2.01;
            VersionName = "Freeshell";
            Author = "iDevYT";
        }

        public void PrintInfo(){
            System.Console.WriteLine($"your {VersionName} is {VersionNumber}. and the .net version is {typeof(string).Assembly.ImageRuntimeVersion}");
        }
    }
}