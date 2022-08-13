using freeshell.api.commands;
using freeshell.api.programInfo;
using freeshell;
using System;
using System.Diagnostics;
using Color = System.ConsoleColor;
using Figgle;

namespace freeshell.api{
    class commandInterfacec{
        public static void commandListen(string? input)
        {
            string welcome = FiggleFonts.Standard.Render("Welcome To Freeshell!");
            bool commands = true;
            ProgramInfo progInfo = new ProgramInfo();
            while(commands){
                 Console.ForegroundColor = Color.Green;
                Console.Write(">");
                input = Console.ReadLine();
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
                    case $"figlet":
                        funCommands.Figlet(input);
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
                    default:
                        Console.WriteLine($"{input} Not Found. Type help for help.");
                        break;
                }
            }
        }
    }
}