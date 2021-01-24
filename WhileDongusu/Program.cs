using System;

namespace WhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            // C #, belirtilen koşul false döndürdüğü sürece while döngüsünün bir kod bloğunu tekrar tekrar yürütmesini sağlar.
            // C# provides the while loop to repeatedly execute a block of code as long as the specified condition returns false.

            int i = 0; // başlangıç değeri

            while (i < 10) // koşul şart
            {
                Console.WriteLine("i = {0}", i);

                i++; // artış
            }
        }
    }
}
