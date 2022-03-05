namespace freeshell
{
    public class fsa
    {
       public static void RunFilePath()
       {
        string rootpath = @"C:\";
        string[] dir = Directory.GetDirectories(rootpath);
        Console.Write(dir +">");
        string? input = Console.ReadLine();
        if (input == "cd" + input)
        {
            rootpath = @input;
        }

       }
    }
}