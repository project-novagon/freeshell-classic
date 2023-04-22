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
            // ! THIS IS JUST FOR SHOW !
            System.Console.WriteLine("Checking for updates... [fpm]");
            Thread.Sleep(1000);
            System.Console.WriteLine("Updates found! [fpm]");
            Thread.Sleep(1000);
            Console.Clear();
            System.Console.WriteLine("Downloading updates... [#         ] 10%[fpm]");
            Thread.Sleep(1000);
            Console.Clear();
            System.Console.WriteLine("Downloading updates... [##        ] 20%[fpm]");
            Thread.Sleep(1000);
            Console.Clear();
            System.Console.WriteLine("Downloading updates... [###       ] 30%[fpm]");
            Thread.Sleep(1000);
            Console.Clear();
            System.Console.WriteLine("Downloading updates... [####      ] 40%[fpm]");
            Thread.Sleep(1000);
            Console.Clear();
            System.Console.WriteLine("Downloading updates... [#####     ] 50%[fpm]");
            Thread.Sleep(1000);
            Console.Clear();
            System.Console.WriteLine("Downloading updates... [######    ] 60%[fpm]");
            Thread.Sleep(1000);
            Console.Clear();
            System.Console.WriteLine("Downloading updates... [#######   ] 70%[fpm]");
            Thread.Sleep(1000);
            Console.Clear();
            System.Console.WriteLine("Downloading updates... [########  ] 80%[fpm]");
            Thread.Sleep(1000);
            Console.Clear();
            System.Console.WriteLine("Downloading updates... [######### ] 90%[fpm]");
            Thread.Sleep(1000);
            Console.Clear();
            System.Console.WriteLine("Downloading updates... [##########] 100%[fpm]");
            Thread.Sleep(1000);
            System.Console.WriteLine("Updates downloaded! [fpm]");
        }

            public static void abtColor(){
                Console.WriteLine("color: color is a freeshell plugin that changes the system color. \n example: color --set {color}  \n colors: red, green, yellow, blue, magenta, cyan, white, gray, black");
            }
            public static void abtColor2(){
                Console.WriteLine("color2: color 2 is a revised version of color. type in color for more info.");
            }
    }
}