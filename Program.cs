using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace better_comments
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            //*FREESHELL v1.0
            System.Console.Write(">");
            string? input = Console.ReadLine();
           System.Console.WriteLine("running " + input);
           if (input == "help")
           {
              System.Console.WriteLine("FRESHELL.NET help \n no help now");
              Main(args);
           }
            if(input == "exit")
            {
                Environment.Exit(0);
            }

            if (input == "proj")
            {
                System.Console.WriteLine("FRESHELL.NET1 by iDev \n GH repo: https://github.com/iDevYT/freeshell");
                Main(args);
            }
        }
    }
}