using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Factorial
    {
        public static void Factoria()
        {

            Console.WriteLine("Introduce el Numero a Obtener el Factorial: ");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;

            for (int i = 1; i <= num; i++)
            {
                fact = (fact * i);
                Console.WriteLine("El Factorial del Numero: " + i + " es: " + fact);
                Console.ReadKey();
            }
        }
}
}
