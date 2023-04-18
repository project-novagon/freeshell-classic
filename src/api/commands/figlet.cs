
using Figgle;

namespace freeshell
{
    public class figlet
    {
        public static void Run(string? input)
        {
            //figlet 1.0.0 by iDevYT
            bool commands = true;
            System.Console.WriteLine("Welcome To Figlet! type \"exit\" to exit");
            while(commands)
            {
            #nullable enable
            input = Console.ReadLine();
            string figletinput = FiggleFonts.Standard.Render(input);
            System.Console.WriteLine(figletinput);
                if (input == "exit")
                {
                    System.Console.WriteLine("Done!");
                    commands = false;           
                }
            }
        }
    }
}