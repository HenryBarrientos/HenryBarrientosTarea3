using System;

namespace T3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double op, radianes, grados ;
            Console.WriteLine("1.GRADOS A RADIANES");
            Console.WriteLine("2.RADIANES A GRADOS");
            op = Convert.ToDouble(Console.ReadLine());

            if (op==1){
                Console.WriteLine("ingrese grados  ");
                grados = Convert.ToDouble(Console.ReadLine());
                radianes = (3.1416 / 180) * grados;
                Console.WriteLine("los radianes son  " + radianes);
            }
            else {
               
                Console.WriteLine("ingrese radianes ");
                radianes = Convert.ToDouble(Console.ReadLine());
                grados = (180 / 3.1416);
                Console.WriteLine("los grados son " + grados);
            }
        }
    }
}
