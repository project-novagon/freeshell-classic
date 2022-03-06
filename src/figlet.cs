using Figgle;

namespace freeshell
{
    public class figlet
    {
        public static void Run()
        {
            string? input = Console.ReadLine();
            string welcome = FiggleFonts.Standard.Render(input);
            System.Console.WriteLine(welcome);
        }
    }
}