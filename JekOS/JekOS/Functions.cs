using System;

namespace JekOS
{
    // Seperate Functions Class
    public static class Functions
    {
        // Parse Text Function
        public static void Parse(string Text)
        {
            // Split the text into an array
            string[] arr = Text.Split(' ');
            // For each Word in array
            foreach (string Word in arr)
            {
                // Check the color (font) of the text
                switch (Word.Split(':')[0].ToUpper())
                {
                    // Welcome color
                    case "1":
                        Console.ForegroundColor = Settings.WelcomeColor;
                        InParse(Word.Split(':')[1]);
                        break;
                        // Number Color
                    case "2":
                        Console.ForegroundColor = Settings.NumberColor;
                        InParse(Word.Split(':')[1]);
                        break;
                        // Any other thing
                    default:
                        Console.ResetColor();
                        InParse(Word.Split(':')[1]);
                        break;
                }
            }
            // Reset color after it has been written
            Console.ResetColor();
        }

        // Inisde parse
        private static void InParse(string Text)
        {
            // Replaceable text (constants)
            if((Text.StartsWith("{")) && (Text.EndsWith("}")))
            {
                switch(Text.ToUpper())
                {
                    // operating system name
                    case "{OSNAME}":
                        Console.Write(Settings.OSName);
                        break;
                        // space character
                    case "{SPACE}":
                        Console.Write(" ");
                        break;
                        // new line character
                    case "{NEW}":
                        Console.WriteLine();
                        break;
                        // default message
                    case "{DEFAULT}":
                        Console.Write("You did not specify a message.");
                        break;
                        // Version number
                    case "{VERSION}":
                        Console.Write(Settings.Version);
                        break;

                }
            } else
            {
                // Anything other than a constant variable
                Console.WriteLine(Text);
            }
        }
    }
}
