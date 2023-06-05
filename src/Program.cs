using System.Diagnostics;
using Color = System.ConsoleColor;
using Figgle;
using System;
using Octokit;
namespace freeshell
{
    public class Program
    {


        public static void Main()
        {
            string currentFilePath = "~/";
            string username = Environment.UserName;
            string computerName = Environment.MachineName;

            var client = new GitHubClient(new ProductHeaderValue("freeshell"));
            var releases = client.Repository.Release.GetLatest("dvnlx", "freeshell");
            var latest = releases.Result;
            ProgramInfo progInfo = new ProgramInfo();
            string welcome = FiggleFonts.Banner3D.Render("Free.shell();");
            Console.WriteLine(welcome);
            progInfo.PrintInfo();
            bool commands = true;
            while (commands)
            {
                Console.Write($"( {username}@{computerName} / {currentFilePath} )");
                Console.Write("> ");
                Console.Write("> ");
                Console.Write("§ ");
                string? input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {

                    switch (input)
                    {
                        case "help":
                            Console.WriteLine("FRESHELL.NET help \n about: shows the project link \n exit: exits the program \n figlet: make a text to ascii text. \n clcon: clears the console \n color: changes the color. type in  \"color\" for more help. \n reload: reloads freeshell. \n fs: the control command for freeshell. type in \"fs\" for help. \n usrinf: showes user information \nthe project is built with c# and .NET\n Thanks");
                            break;
                        case "exit":
                            Console.ForegroundColor = Color.White;
                            Console.WriteLine("Bye!");
                            commands = false;
                            break;
                        case "about":
                            Console.WriteLine(FiggleFonts.Banner3D.Render("Free.shell();"));
                            Console.WriteLine($"Freeshell {progInfo.VersionNumber} by dvnlx \n GH repo: https://github.com/dvnlx/freeshell \n Enjoy! ");
                            try
                            {

                                if (latest.TagName == progInfo.VersionNumber)
                                {
                                    System.Console.WriteLine("You Have the newest version of freeshell.");
                                }
                                else
                                {
                                    System.Console.WriteLine($"You dont have the newest freeshell version. download it by typing \"fs update\". Current release: {latest.TagName}, Your release: {progInfo.VersionNumber}");
                                }
                            }
                            catch
                            {
                                System.Console.WriteLine("Could not check for releases! check your internet connection (FS04)");
                            }
                            break;
                        case "figlet":
                            figlet.Run(input);
                            break;
                        case "clcon":
                            Console.Clear();
                            progInfo.PrintInfo();
                            break;
                        case "hello":
                            System.Console.WriteLine("Hello World!");
                            break;
                        case "reload":
                            System.Console.WriteLine("Reloading...");
                            Console.WriteLine(welcome);
                            progInfo.PrintInfo();
                            break;
                        case "color":
                            plugins.abtColor();
                            break;
                        case "fpm update":
                            plugins.checkForUpdates();
                            break;
                        case var str when str.StartsWith("color -s"):
                            input = input.Replace("color -s", "");
                            color.Run(input);
                            break;
                        case "fs update":
                            fs.updateLatest();
                            break;
                        case var str when str.StartsWith("fs search -r"):
                            input = input.Replace("fs search -r ", "");
                            fs.searchReleases(input);
                            break;
                        case "usrinf":
                            System.Console.WriteLine("Currently Logged In:");
                            System.Console.WriteLine($"{username}@{computerName}");
                            break;
                        case "dskinf":
                            string drivePath = "/"; // Replace with the path of the directory you want to check
                            long freeSpace;

                            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                            {
                                DriveInfo driveInfo = new DriveInfo("C"); // Replace "C" with the drive letter you want to check
                                freeSpace = driveInfo.AvailableFreeSpace;
                            }
                            else if (Environment.OSVersion.Platform == PlatformID.Unix)
                            {
                                Process process = new Process();
                                process.StartInfo.FileName = "df";
                                process.StartInfo.Arguments = $"-k --output=avail {drivePath}";
                                process.StartInfo.RedirectStandardOutput = true;
                                process.StartInfo.UseShellExecute = false;
                                process.StartInfo.CreateNoWindow = true;

                                process.Start();
                                string output = process.StandardOutput.ReadToEnd();
                                process.WaitForExit();

                                string[] lines = output.Trim().Split('\n');
                                string[] fields = lines[1].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                long availableKilobytes = long.Parse(fields[0]);
                                freeSpace = availableKilobytes * 1024;
                            }
                            else
                            {
                                Console.WriteLine("Operating system not supported.");
                                return;
                            }

                            Console.WriteLine($"Free Space on your partition: {FormatBytes(freeSpace)}");

                            string fileSystem;

        if (Environment.OSVersion.Platform == PlatformID.Win32NT)
        {
            DriveInfo driveInfo = new DriveInfo("C"); // Replace "C" with the drive letter you want to check
            fileSystem = driveInfo.DriveFormat;
        }
        else if (Environment.OSVersion.Platform == PlatformID.Unix)
        {
            Process process = new Process();
            process.StartInfo.FileName = "df";
            process.StartInfo.Arguments = $"-T {drivePath}";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            string[] lines = output.Trim().Split('\n');
            string[] fields = lines[1].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            fileSystem = fields[1];
        }
        else
        {
            Console.WriteLine("Operating system not supported.");
            return;
        }

        Console.WriteLine($"Partition File System: {fileSystem}");

                            break;
                        // TODO: add cd and ls commands for filesystem support
                        default:
                            Console.WriteLine($"{input} Not Found. Type help for help. (FS01)");
                            break;
                    }
                }
                else
                {
                    System.Console.WriteLine("No command entered (FS05)");
                }
            }
        }

        static string FormatBytes(long bytes)
        {
            const int scale = 1024;
            string[] units = { "B", "KB", "MB", "GB", "TB", "PB" };

            int magnitude = (int)Math.Log(bytes, scale);
            decimal adjustedSize = (decimal)bytes / (1L << (magnitude * 10));

            return $"{adjustedSize:n2} {units[magnitude]}";
        }
    }

    public class ProgramInfo
    {
        public string VersionNumber { get; set; }
        public string appName { get; set; }



        public ProgramInfo()
        {
            VersionNumber = "v2.3.2";
            appName = "Freeshell";
        }

        public void PrintInfo()
        {
            System.Console.WriteLine($"your Freeshell version is {VersionNumber} and the .net version is {typeof(string).Assembly.ImageRuntimeVersion}");
        }
    }
}