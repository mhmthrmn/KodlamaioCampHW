using System;

namespace SwitchYapisi
{
    class Program
    {
        static void Main(string[] args)
        {

            // Bir değişkeni üç veya daha fazla koşula göre test etmek istediğinizde, if else yerine switch ifadesi kullanılabilir. 
            // The switch statement can be used instead of if else statement when you want to test a variable against three or more conditions.

            int x = 10;

            switch (x)
            {
                case 5:
                    Console.WriteLine("x değeri 5");
                    break;
                case 10:
                    Console.WriteLine("x değeri 10");
                    break;
                case 15:
                    Console.WriteLine("x değeri 15");
                    break;
                default:
                    Console.WriteLine("bilinmeyen değer");
                    break;
            }

        }
    }
}
