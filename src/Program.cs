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

        public static void Main(string[] args)
        {   
            string welcome = FiggleFonts.Standard.Render("Welcome To Freeshell!");
            bool commands = true;
            while (commands) 
            {
            Console.ForegroundColor = Color.Green;
            Console.WriteLine(welcome);
            Console.Write(">");
            string? input = Console.ReadLine();
            Console.WriteLine($"running {input}");
            switch (input)
                {
                case "help":
                    Console.WriteLine("FRESHELL.NET help \n no help now");
                    break;
                case "exit":
                    Console.ForegroundColor = Color.White;
                    Console.WriteLine("Bye!");
                    commands = false;
                    break;
                case "proj":
                    Console.WriteLine("FRESHELL.NET1 by iDev \n GH repo: https://github.com/iDevYT/freeshell \n Enjoy! ");
                    break;
                case "figlet":
                    freeshell.src.figlet.Run();
                    break;    
                default:
            	    Console.WriteLine($"{input} Not Found. Type help for help.");
                    break;	
            	}   
            }           
        }
    }
}