using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Palun sisestada kasutajatunnus:");
                string user = Console.ReadLine();
                Console.WriteLine("Palun sisestada Parool:");
                string parool = Console.ReadLine();
                Console.WriteLine("Palun sisestada PIN:");
                string PIN = Console.ReadLine();
                if (PIN.Length > 4)
                {
                    Console.WriteLine("Vale Pin. Proovi uuesti.");

                }
                else if (user == "user1" && parool == "password1" && PIN == "1532")
                {
                    Console.WriteLine("Tere Tulemast.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Midagi läks valesti {3 - i} katset alles. Proovi uuesti.");
                    i = i + 1;
                }

              }

            }
    }
}
