using System;
using Sys = Cosmos.System;

namespace JekOS
{
    // The kernel class
    public class Kernel : Sys.Kernel
    {
        // Current location
        public static string CurrentLocation = @"0:\";

        // Before the terminal
        protected override void BeforeRun()
        {
            // Clear the console
            Console.Clear();
            // Show the welcome message
            Functions.Parse(Settings.Message(0));
        }

        protected override void Run()
        {
            // Write an empty line
            Console.WriteLine();
            // Show the current location (we may want to change this)
            Console.Write(CurrentLocation + ">");
            // Read from the console
            string input = Console.ReadLine();
            // Split into an array
            string[] parts = input.Split(' ');
            // Send to the console
            Terminal.Exec(parts);
            // Go to top
        }
    }
}
