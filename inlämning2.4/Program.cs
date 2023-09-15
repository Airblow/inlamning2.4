using System;
namespace inlämning2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur mycket får den första anställda i lön?");
            string ans1t = Console.ReadLine();
            int ans1n = int.Parse(ans1t);
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Hur mycket får den andra anställda i lön?");
            string ans2t = Console.ReadLine();
            int ans2n = int.Parse(ans2t);
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Hur mycket får den tredje anställda i lön?");
            string ans3t = Console.ReadLine();
            int ans3n = int.Parse(ans3t);
            Console.WriteLine("---------------------------------------------");

            int medlön = (ans1n + ans2n + ans3n) / 3;
            Console.WriteLine("Medellönen bland dina anställda är " + medlön + " kr");
            Console.ReadKey();

        }

    }

}
