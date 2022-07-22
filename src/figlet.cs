
using Figgle;

namespace freeshell
{
    public class figlet
    {
        public static void Run(string? input)
        {
            //figlet 1.0.0 by iDevYT
            #nullable enable
            input = Console.ReadLine();
            string figletinput = FiggleFonts.Standard.Render(input);
            System.Console.WriteLine(figletinput);
        }
    } 
}