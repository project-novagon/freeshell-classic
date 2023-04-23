using Color = System.ConsoleColor;

namespace freeshell
{
    public class color
    {
        public static void Run(string? argcol)
        {
         if (!string.IsNullOrEmpty(argcol))
        {
            try
            {
                ConsoleColor parsedColor;
                if (Enum.TryParse(argcol, true, out parsedColor))
                {
                    Console.ForegroundColor = parsedColor;
                    Console.WriteLine($"Set to {argcol}");
                }
                else
                {
                    Console.WriteLine("Invalid color (FS02)");
                }
            }
            catch
            {
                Console.WriteLine("Invalid color (FS02)");
            }
        }
        else
        {
            Console.WriteLine("Input color is empty (FS03)");
        }
        }
    }
}