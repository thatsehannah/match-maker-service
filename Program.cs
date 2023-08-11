using System;

namespace MatchMakerService
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");
            sam.SetHobbies(new string[] { "listening to audiobooks and podcats", "playing rec sports like basketball and raquetball", "writing a speculative fiction novel", "reading advice columns" });
            Console.WriteLine(sam.ViewProfile());

        }
    }
}

