
using Figgle;

namespace freeshell.cmd
{
    public class figlet
    {
        public static void Run(string? input)
        {
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