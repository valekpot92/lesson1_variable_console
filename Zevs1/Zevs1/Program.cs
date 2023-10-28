using System; 

namespace Zevs1
{
    class Program
    {
        static void Main(string[] args)
        {

            static void Main(string[] args)
            {
                var d = MyRound2();
                var r = MyRound(112.849, 1);
                Console.WriteLine($"Значение d: {d}");
                Console.WriteLine($"Значение r: {r}");
                double y = 12f / 221f;
                long x = 12 % 221;
                Console.WriteLine($"Значение y: {y}");
                Console.WriteLine($"Значение x: {x}");

                Console.WriteLine("----------------------------------------------");
                Condition("");
                Condition("Зевс");
                Condition("25.4");
                Condition("25");
                ConditionErr("Зевс");
                ConditionErr("28");
                ConditionSwitch(0);
                ConditionSwitch(1);
                ConditionSwitch(2);
            }

            static double MyRound(double valyok, int dec)
            {
                double result = Math.Round(valyok, dec);
                return result;
            }

            static double MyRound2()
            {
                return Math.Round(112.849, 1);
            }

            static void ConditionErr(string s)
            {
                try
                {
                    var i = int.Parse(s);
                    Console.WriteLine($"Значение i: {i}");
                }
                catch (Exception err)
                {
                    Console.WriteLine($"Ошибка преобразования: {err}");
                    //throw;
                }
                finally
                {
                    Console.WriteLine("Завершение выполнения метода ConditionErr");
                }
            }


            static void Condition(string s)
            {
                if (string.IsNullOrEmpty(s))
                {
                    Console.WriteLine("Строка пустая!");
                }
                else if (int.TryParse(s, out int result))
                {
                    Console.WriteLine($"Вы ввели число: {result}");
                }
                else
                {
                    Console.WriteLine($"Строка: {s}");
                }
            }

            static void ConditionSwitch(int u)
            {
                switch (u)
                {
                    case 1:
                        Console.WriteLine("Вы ввели 1.");
                        break;
                    case 2:
                        Console.WriteLine("Вы ввели 2.");
                        break;
                    default:
                        Console.WriteLine("вы ввели какую-то хуйню!");
                        break;
                }
            }
        }
    }
}
