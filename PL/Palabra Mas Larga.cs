using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Palabra_Mas_Larga
    {
        public static void Large(string palabra)
        {
            string largo = string.Empty;
            Console.WriteLine("Ingresa una frase");
            palabra = Console.ReadLine();

            var separar = palabra.Split();

            for (int i = 0; i < separar.Length; i++)
            {
                if (largo.Length <= separar[i].Length)
                {
                    largo = separar[i];
                }
            }
            Console.WriteLine("La palabra mas larga de la frase es:" + largo);
        }
    }
}
