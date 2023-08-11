using System;

namespace MatchMakerService
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");
            Console.WriteLine(sam.ViewProfile());

        }
    }
}

