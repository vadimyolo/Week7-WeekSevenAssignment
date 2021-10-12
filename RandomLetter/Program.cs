using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada eesnime, siis see kuvab juhuslikku tähte kasutaja eesnimest.

            Console.WriteLine("Palun sisesta enda eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine($"Tere, {firstName.ToUpper()[0]}");
        }
    }
}
