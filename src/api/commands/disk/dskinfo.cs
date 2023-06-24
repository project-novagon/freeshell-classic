using System.Diagnostics;

namespace freeshell.cmd
{
    public class dskinf
    {
        public static void run()
        {
            string drivePath = "/"; // Replace with the path of the directory you want to check

            long freeSpace;
            string fileSystem;

            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                DriveInfo driveInfo = new DriveInfo("C"); // Replace "C" with the drive letter you want to check
                freeSpace = driveInfo.AvailableFreeSpace;
                fileSystem = driveInfo.DriveFormat;
            }
            else if (Environment.OSVersion.Platform == PlatformID.Unix)
            {
                Process process = new Process();
                process.StartInfo.FileName = "df";
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
                fileSystem = fields[1];
            }
            else
            {
                Console.WriteLine("Operating system not supported.");
                return;
            }

            Console.WriteLine($"Free Space on your partition: {FormatBytes(freeSpace)}");
            Console.WriteLine($"Partition File System: {fileSystem}");
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
}