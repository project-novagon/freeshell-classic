using System;
using System.IO;

namespace freeshell.cmd
{
    class listFiles
    {
        public static void run()
        {
            string homeFolderPath;

            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                homeFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            }
            else if (Environment.OSVersion.Platform == PlatformID.Unix)
            {
                homeFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            }
            else
            {
                Console.WriteLine("Operating system not supported.");
                return;
            }

            try
            {
                string[] files = Directory.GetFiles(homeFolderPath);
                string[] directories = Directory.GetDirectories(homeFolderPath);

                foreach (string file in files)
                {
                    string relativePath = GetRelativePath(file, homeFolderPath);
                    Console.Write("[FILE]: ");
                    Console.WriteLine(relativePath);
                }

                foreach (string directory in directories)
                {
                    string relativePath = GetRelativePath(directory, homeFolderPath);
                    Console.Write("[DIR]: ");
                    Console.WriteLine(relativePath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"(FS07): An error occurred: {ex.Message}");
            }
        }

        static string GetRelativePath(string fullPath, string basePath)
        {
            string relativePath;
            try
            {
                relativePath = Path.GetRelativePath(basePath, fullPath);
            }
            catch (ArgumentException)
            {
                relativePath = fullPath;
            }
            return relativePath;
        }
    }
}
