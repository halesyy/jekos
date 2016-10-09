using System;
using Sys = Cosmos.System;

namespace JekOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("jekOS 1.0 running");
        }

        protected override void Run()
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            Console.Write(parts[0]);
            Console.ReadKey();
        }
    }
}
