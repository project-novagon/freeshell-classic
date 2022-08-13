using Figgle;

namespace freeshell.api.commands
{
    public class funCommands
    {
     public static void Figlet (string text)
     {
             //figlet 1.0.0 by iDevYT
            bool commands = true;
            while(commands)
            {
            #nullable enable
            System.Console.WriteLine("Welcome to Figlet! \n a Freeshell Sub-app made by iDevYT! \n press enter to exit.");
            text = Console.ReadLine();
            string figletinput = FiggleFonts.Standard.Render(text);
            System.Console.WriteLine(figletinput);
                if (text == null)
                {
                    System.Console.WriteLine("Please enter a string to be converted to figlet");
                    commands = false;           
                }
            } 
        
     }
    }
}