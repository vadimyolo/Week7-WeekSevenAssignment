using System;

namespace FullNameInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisestada oma eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Palun sisesta oma perekonnanimi;");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Tere, {firstName[0]}. {lastName[0]}.!");
        }
    }
}
