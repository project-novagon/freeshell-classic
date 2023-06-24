using System.Diagnostics;
using Color = System.ConsoleColor;
using Figgle;
using System;

namespace freeshell
{
    public class plugins
    {
        public static void checkForUpdates()
        {
            System.Console.WriteLine("(FS08): Planned for Freeshell 3.0");
        }

            public static void abtColor(){
                Console.WriteLine("color: color is a freeshell plugin that changes the system color. \n example: color --set {color}  \n colors: red, green, yellow, blue, magenta, cyan, white, gray, black");
            }
            public static void abtFS(){
                System.Console.WriteLine("fs: the command to manage freeshell. \n fs update: used tu update freeshell.");
            }
    }
}