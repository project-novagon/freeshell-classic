using Figgle;
using Color = System.ConsoleColor;

namespace freeshell
{
    public class color
    {
        public static void Run(string? argcol)
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), argcol);
            Console.WriteLine($"Set to {argcol}");

        }
    }
}