using Igtampe.BasicWindows;
using Color = System.ConsoleColor;
using Figgle;

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
                        Console.WriteLine("FRESHELL.NET help \n about: shows the project link \n exit: exits the program \n figlet: make a text to ascii text. \n clcon: clears the console \n Thanks");
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
                        break;
                    case "window":
                        Window win = new Window(Animated: true , Shadowed: true , LeftPos: 34, MainBG: ConsoleColor.Blue, HeaderBG: ConsoleColor.Red, HeaderFG: ConsoleColor.White , Length: 100, Height: 50, Title: "Welcome To Freeshell!", HeadPos: HeaderPosition.CENTER, TopPos: 50);
                        win.Execute();
                        Thread.Sleep(2000);
                        win.Close();
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
            VersionNumber = 1.9;
            VersionName = "Freeshell";
            Author = "iDevYT";
        }

        public void PrintInfo(){
            System.Console.WriteLine($"your {VersionName} is {VersionNumber}.");
        }
    }
}