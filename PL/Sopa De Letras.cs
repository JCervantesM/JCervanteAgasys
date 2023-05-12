using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Sopa_De_Letras
    {
        public static void Sopa(string palabra)
        {
            string nuevo = string.Empty;
            Console.WriteLine("Ingresa una palabra:");
            palabra = Console.ReadLine();

            char[] pa = palabra.ToCharArray();

            Array.Sort(pa);

            nuevo = new string(pa);
            Console.WriteLine("La palabra corregida es " + nuevo);
            Console.WriteLine();
        }
    }
}
