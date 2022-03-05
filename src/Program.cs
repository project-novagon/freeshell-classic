using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Color = System.ConsoleColor;
using Figgle;

namespace freeshell
{
    public class Program
    {
        public static string? input = Console.ReadLine();

        public static void Main(string[] args)
        {   
            Console.ForegroundColor = Color.Green;
            string welcome = FiggleFonts.Standard.Render("Welcome To Freeshell!");
            System.Console.WriteLine(welcome);
            Console.Write(">");
            Console.WriteLine("running " + input);
            if (input == "help")
            {
              System.Console.WriteLine("FRESHELL.NET help \n no help now");
              Main(args);
            }else if(input == "exit")
            {
                Environment.Exit(0);
            
            }else if (input == "proj")
            {
                System.Console.WriteLine("FRESHELL.NET1 by iDev \n GH repo: https://github.com/iDevYT/freeshell \n Enjoy! ");
                Main(args);
            }else if(input == "fs")
            {
                fsa.RunFilePath();
            }else if (string.IsNullOrEmpty(input))
            {
                System.Console.WriteLine("Type somthing! type 'help' for help.");
                Main(args);
            }
            else
            {
                System.Console.WriteLine("Unknown Command! type 'help' for help.");
                
            }
        }
    }
}