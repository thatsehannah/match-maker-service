using System;

namespace MatchMakerService
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");
            Console.WriteLine(sam.ViewProfile());
            sam.SetHobbies(new string[] { "listening to audiobooks and podcats", "playing rec sports like basketball and raquetball", "writing a speculative fiction novel", "reading advice columns" });
            Console.WriteLine(sam.ViewProfile());
            Console.WriteLine();
            Profile jaxson = new Profile("Jaxson Sanders", 15, "Wyoming", "USA");
            Console.WriteLine(jaxson.ViewProfile());
            jaxson.SetHobbies(new string[] { "listening to audiobooks and podcats", "playing rec sports like basketball and raquetball", "writing a speculative fiction novel", "reading advice columns" });
        }
    }
}

