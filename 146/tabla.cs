using System;

namespace tabla
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n, b, c;

            Console.WriteLine("Ingrese un numero  ");
            n = Convert.ToInt32(Console.ReadLine());

            for (c = 1; c <= 10; c++)
            {

                b = c * n;
                Console.WriteLine($"  {n}  *   {c} =  {b}");
            }
        }
    }
}
