using System.Diagnostics;
using Color = System.ConsoleColor;
using Figgle;
using System;
using Octokit;

namespace freeshell
{

    public class fs
    {
        public static void updateLatest()
        {
            try
            {
                var client = new GitHubClient(new ProductHeaderValue("freeshell"));
                var releases = client.Repository.Release.GetLatest("dvnlx", "freeshell");
                var latest = releases.Result;
                Console.WriteLine(
                    "The latest Freeshell release is {0}",
                    latest.TagName);

                Console.Write("\x1b[1mNOTE:\x1b[0m");
                System.Console.WriteLine(" If you dont have the newest version get it here:");
                System.Console.WriteLine("---");
                System.Console.WriteLine("https://github.com/dvnlx/freeshell/releases/latest");
                System.Console.WriteLine("---");
                System.Console.WriteLine("or get the beta here:");
                System.Console.WriteLine("---");
                System.Console.WriteLine("https://github.com/dvnlx/freeshell/releases/tag/v2.3.0.1_beta");
                System.Console.WriteLine("---");
            }
            catch
            {
                System.Console.WriteLine("Could not find newest Release! check your internet connection (FS04)");
            }

        }

        public static void searchReleases(string TagName)
        {
            var client = new GitHubClient(new ProductHeaderValue("freeshell"));

            var releases = client.Repository.Release.GetAll("dvnlx", "freeshell").Result;
            bool releaseFound = false;

            foreach (var release in releases)
            {
                if (release.TagName.Equals(TagName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Release Name: {release.Name}");
                    Console.WriteLine($"{release.Body}");
                    Console.WriteLine();
                    releaseFound = true;
                }
            }

            if (!releaseFound)
            {
                Console.WriteLine($"release {TagName} not found. (FS06)");
            }

        }
    }
}