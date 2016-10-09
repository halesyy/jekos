using System;

namespace JekOS
{
    // Setting Class
    public static class Settings
    {
        // Version number
        public static readonly string Version = "1.0";
        // Operating System name
        public static readonly string OSName = "jekOS";
        // Welcome Color
        public static readonly ConsoleColor WelcomeColor = ConsoleColor.Blue;
        // Number Color
        public static readonly ConsoleColor NumberColor = ConsoleColor.DarkMagenta;

        // Messages (to parse)
        public static string Message(int num)
        {
            // switch by number
            switch(num)
            {
                // Welcome message
                case 0:
                    return "1:{OSNAME} 0:{SPACE} 2:{VERSION} 0:{SPACE} 1:running";
                // Default message
                default:
                    return "0:{DEFAULT}";
            }
        }
    }
}
