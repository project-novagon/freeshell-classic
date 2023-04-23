using System.Diagnostics;
using Color = System.ConsoleColor;
using Figgle;
using System;

namespace freeshell
{
    public class Program
    {

        public static void Main()
        {
            ProgramInfo progInfo = new ProgramInfo();
            string welcome = FiggleFonts.Banner3D.Render("Free.shell();");
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
                        Console.WriteLine($"Freeshell version {progInfo.VersionNumber} by {progInfo.Author} \n GH repo: https://github.com/dvnlx/freeshell \n Enjoy! ");
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
                    case "fpm update":
                        plugins.checkForUpdates();
                        break;
                    case "color2":
                    plugins.abtColor2();
                    break;
                    case var str when str.StartsWith("color2 -s"):
                    input = input.Replace ("color2 -s", "");
                    color.Run(input);
                    break;
                    case "fs update":
                    freeshell.freeshellUpdate.LatestRelease();
                    break;
                    default:
                        Console.WriteLine($"{input} Not Found. Type help for help. (FS01)");
                        break;
                }
            }
        }
    }

    public class ProgramInfo
    {
        public string VersionNumber { get; set; }
        public string appName { get; set; }
        public string Author { get; set; }



        public ProgramInfo()
        {
            VersionNumber = "2.3.0.2 beta";
            appName = "Freeshell";
            Author = "dvnlx";
        }

        public void PrintInfo()
        {
            System.Console.WriteLine($"your Freeshell version is {VersionNumber} and the .net version is {typeof(string).Assembly.ImageRuntimeVersion}");
        }
    }
}