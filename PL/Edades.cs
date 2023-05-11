using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Edades
    {
        public static void Edad()
        {
            int mayores = 0;
            int menores = 0;

            for (int i = 0; i < 15; i++)
            {
                int edad;
                Console.WriteLine("Ingresa tu Edad:");
                edad = int.Parse(Console.ReadLine());

                if (edad >= 18)
                {
                    mayores = mayores + 1;
                }
                else
                {
                    menores = menores + 1;
                }
                Console.Clear();
            }

            Console.WriteLine("El numero de personas Mayores es: " + mayores);
            Console.WriteLine("El numero de personas Menores es: " + menores);
            Console.ReadLine();
        }
    }
}
