using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("ingrese un numero entero (con 0 se finaliza)");
                num = int.Parse(Console.ReadLine());

                if (num >= 10) ;
                {
                    Console.WriteLine("tiene 3 digitos");
                }
                else if (num >= 10)
                {
                    Console.WriteLine("tiene 2 digitos");
                }
                else
                {
                    Console.WriteLine("tiene 1 digito");
                }
            } while (num != 0);



        }
    }
}
