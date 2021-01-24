using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {

            // C #, koşullu operatör veya üçlü operatör olarak adlandırılan bir karar verme operatörü içerir? If else koşullarının kısa biçimidir.
            // C# includes a decision-making operator ?: which is called the conditional operator or ternary operator. It is the short form of the if else conditions.

            int x = 20, y = 10;

            if (x>y)
            {
                Console.WriteLine("x y den büyüktür");
            }
            else
            {
                Console.WriteLine("x y den küçüktür");
            }

            var sonuc = x > y ? "x y den büyüktür" : "x y den küçüktür";

            Console.WriteLine(sonuc);
        }
    }
}
