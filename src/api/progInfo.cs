using freeshell.api.commands;
using System.Diagnostics;
using Color = System.ConsoleColor;
using Figgle;

namespace freeshell.api.programInfo{
        public class ProgramInfo{
        public double VersionNumber { get; set; }
        public string VersionName { get; set; }
        public string Author { get; set; }



        public ProgramInfo(){
            VersionNumber = 2.01;
            VersionName = "Freeshell";
            Author = "iDevYT";
        }

        public void PrintInfo(){
            System.Console.WriteLine($"your {VersionName} is {VersionNumber}. and the .net version is {typeof(string).Assembly.ImageRuntimeVersion}");
        }
    }
}