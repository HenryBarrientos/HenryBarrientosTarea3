using System;

namespace elevado
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int r = 1;

            Console.WriteLine("Ingrese el numero ");
            a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el exponente ");
            b = Convert.ToInt32(Console.ReadLine());

            for (c = 1; c <= b; c++)
            {

                r = r * a;


            }
            Console.WriteLine($"el resultado es  {r} " );
        }
    }
}
