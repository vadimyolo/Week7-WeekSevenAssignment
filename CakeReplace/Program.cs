using System;

namespace CakeReplace
{
    class Program
    {
        static void Main(string[] args)

            //programm peab asendama koik 4 lauses the c4ke i3 4 l1e a tahtedega, koik 1 'i' tahtedega, koik 3 's' tahtedega
        {
            string cake = "the c4ke i3 4 l1e";

            Console.WriteLine($"{cake}.", cake);

            cake = cake.Replace("4", "a").Replace("3", "s").Replace("1", "i");

            Console.WriteLine($"{cake}", cake);
        }
    }
}
