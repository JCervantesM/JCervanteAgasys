using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Cambio_de_Letras
    {
        public static void Posicion(string palabra)
        {

            string nuevo = string.Empty;
            char[] vec = new char[50];
            Console.WriteLine("Ingresa una palabra:");
            palabra = Console.ReadLine();

            char[] pa = palabra.ToCharArray();

            for (int i = 0; i < palabra.Length; i++)
            {
                //Console.WriteLine(pa[i]+1);
                vec[i] = ((char)(pa[i] + 1));

            }

            nuevo = new string(vec);
            Console.WriteLine("La palabra corregida es " + nuevo);
            Console.WriteLine();
        }
    }
}
