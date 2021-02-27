using System;

namespace T3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int L,R ,P;
            Console.WriteLine("INGRESE LOS LADOS DEL POLIGONO");
            L = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INGRESE EL RADIO DEL POLIGONO");
            R= Convert.ToInt32(Console.ReadLine());
            P = L * R;
            Console.WriteLine("EL PERIMETRO ES  " + P);
        }
    }
}
