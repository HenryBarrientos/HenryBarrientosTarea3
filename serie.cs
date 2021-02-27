using System;

namespace serie
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            int a = 0;
            int b = 1;
            int c;
            int d;
            int ab = 0;
           
            Console.WriteLine("ingrese un numero ");
            c = Convert.ToInt32(Console.ReadLine());

            for (d = 0; d < c; d++)
            {
                if (d == 0)
                {
                    Console.Write("la serie  es " + a);
                }
                else
                {
                    
                    a = b;
                    b = ab + a;
                    ab = a;
                    Console.Write(" {0}", a);
                }
            }

        }
    }
}
