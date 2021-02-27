using System;

namespace factorial
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n;
            int b = 1;
            int a;
            Console.Write("Introduce un numero : ");
            n = int.Parse(Console.ReadLine());

            for (a = 2; a <= n; a++)
            {
                b = b * a;

            }
            Console.WriteLine($"El factorial de {n}es  {b}");
        }
    }
}
