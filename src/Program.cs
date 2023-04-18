using System.Diagnostics;
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
                Console.Write("( ~/ )");
                Console.Write("> ");
                Console.Write("> ");
                Console.Write("§ ");
                string? input = Console.ReadLine();
                Console.WriteLine($"running {input}");
                switch (input)
                {
                    case "help":
                        Console.WriteLine("FRESHELL.NET help \n about: shows the project link \n exit: exits the program \n figlet: make a text to ascii text. \n clcon: clears the console \n color: changes the color. type in  \"color\" for more help. \n the project is built with c# and .NET\n Thanks");
                        break;
                    case "exit":
                        Console.ForegroundColor = Color.White;
                        Console.WriteLine("Bye!");
                        commands = false;
                        break;
                    case "about":
                        Console.WriteLine($"Freeshell version {progInfo.VersionNumber} by {progInfo.Author} \n GH repo: https://github.com/iDevYT/freeshell \n Enjoy! ");
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
                        plugins.abtColor();                        
                        break;
                    case "color --set red":
                        Console.ForegroundColor = Color.Red;
                        Console.WriteLine("Set to red!");
                        break;
                    case "color --set green":
                        Console.ForegroundColor = Color.Green;
                        Console.WriteLine("Set to green!");
                        break;
                    case "color --set yellow":
                        Console.ForegroundColor = Color.Yellow;
                        Console.WriteLine("Set to yello!w");
                        break;
                    case "color --set blue":
                        Console.ForegroundColor = Color.Blue;
                        Console.WriteLine("Set to blue"!);
                        break;
                    case "color --set magenta":
                        Console.ForegroundColor = Color.Magenta;
                        Console.WriteLine("Set to magen!ta");
                        break;
                    case "color --set cyan":
                        Console.ForegroundColor = Color.Cyan;
                        Console.WriteLine("Set to cyan"!);
                        break;
                    case "color --set white":
                        Console.ForegroundColor = Color.White;
                        Console.WriteLine("Set to white!");
                        break;
                    case "color --set gray":
                        Console.ForegroundColor = Color.DarkGray;
                        Console.WriteLine("Set to gray"!);
                        break;
                    case "color --set black":
                        Console.ForegroundColor = Color.Black;
                        Console.WriteLine("Set to black!");
                        break;
                    case "freefetch":
                        System.Console.WriteLine("Free.shell();");
                        progInfo.PrintInfo();
                        System.Console.WriteLine("\n Thank you for using Freeshell!");
                        break;
                    case "fpm update":
                        plugins.checkForUpdates();
                        break;
                    default:
                        Console.WriteLine($"{input} Not Found. Type help for help.");
                        break;
                }
            }
        }
    }

    public class ProgramInfo
    {
        public double VersionNumber { get; set; }
        public string appName { get; set; }
        public string Author { get; set; }



        public ProgramInfo()
        {
            VersionNumber = 2.2;
            appName = "Freeshell";
            Author = "iDevYT";
        }

        public void PrintInfo()
        {
            System.Console.WriteLine($"your Freeshell version is {VersionNumber}. and the .net version is {typeof(string).Assembly.ImageRuntimeVersion}");
        }
    }
}