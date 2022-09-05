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
            Console.ForegroundColor = Color.Green;
            progInfo.PrintInfo();
            bool commands = true;
            while (commands)
            {
                Console.Write(". ~/ ");
                Console.ForegroundColor = Color.Red;
                Console.Write("> ");
                Console.ForegroundColor = Color.Yellow;
                Console.Write("> ");
                Console.ForegroundColor = Color.Blue;
                Console.Write("§ ");
                Console.ForegroundColor = Color.Green;
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
                            Console.WriteLine("color: color is a freeshell utility that changes the system color. \n example: color --set {color}  \n colors: red, green, yellow, blue, magenta, cyan, white, gray, black");
                            break;
                        case "color --set red":
                            Console.ForegroundColor = Color.Red;
                            Console.WriteLine("red");
                            break;
                        case "color --set green":
                            Console.ForegroundColor = Color.Green;
                            Console.WriteLine("green");
                            break;
                        case "color --set yellow":
                            Console.ForegroundColor = Color.Yellow;
                            Console.WriteLine("yellow");
                            break;
                        case "color --set blue":
                            Console.ForegroundColor = Color.Blue;
                            Console.WriteLine("blue");
                            break;
                        case "color --set magenta":
                            Console.ForegroundColor = Color.Magenta;
                            Console.WriteLine("magenta");
                            break;
                        case "color --set cyan":
                            Console.ForegroundColor = Color.Cyan;
                            Console.WriteLine("cyan");
                            break;
                        case "color --set white":
                            Console.ForegroundColor = Color.White;
                            Console.WriteLine("white");
                            break;
                        case "color --set gray":
                            Console.ForegroundColor = Color.DarkGray;
                            Console.WriteLine("gray");
                            break;
                        case "color --set black":
                            Console.ForegroundColor = Color.Black;
                            Console.WriteLine("black");
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
            public string VersionName { get; set; }
            public string Author { get; set; }



            public ProgramInfo()
            {
                VersionNumber = 2.01;
                VersionName = "Freeshell";
                Author = "iDevYT";
            }

            public void PrintInfo()
            {
                System.Console.WriteLine($"your {VersionName} is {VersionNumber}. and the .net version is {typeof(string).Assembly.ImageRuntimeVersion}");
            }
        }
    }