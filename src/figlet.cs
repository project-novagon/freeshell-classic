
using Figgle;

namespace freeshell
{
    public class figlet
    {
        public static void Run(string? input)
        {
            bool commands = true;
            while(commands)
            {
            #nullable enable
            input = Console.ReadLine();
            string figletinput = FiggleFonts.Standard.Render(input);
            System.Console.WriteLine(figletinput);
                if (input == null)
                {
                    System.Console.WriteLine("Please enter a string to be converted to figlet");
                    commands = false;           
                }
            } 
        }
    } 
}