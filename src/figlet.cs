
using Figgle;

namespace freeshell
{
    public class figlet
    {
        public static void Run(string? input)
        {
            input = Console.ReadLine();
            string figletinput = FiggleFonts.Standard.Render(input);
            System.Console.WriteLine(figletinput);
        }
    }
}