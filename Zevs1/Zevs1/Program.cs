using System; 

namespace Zevs1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool zevs = true;
            int a = 0;
            long b = 1;
            uint c = 2;

            float s = 1.9F;
            Console.Write("Введите b: > ");
            b = long.Parse(Console.ReadLine());
            Console.Write("Введите a: > ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"c: {c}");
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"Сумма b, c и a: {b + c + a}");
            var ck = Console.ReadKey();
            Console.WriteLine($"{ck.KeyChar}");
            Console.ReadKey();
        }
    }
}
