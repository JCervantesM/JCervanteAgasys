using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra = string.Empty;
            //PL.Edades.Edad();
            //PL.Votos.Voto();
            //PL.Factorial.Factoria();
            //PL.Cambio_de_Letras.Posicion(palabra);
            PL.Sopa_De_Letras.Sopa(palabra);
            //PL.Palabra_Mas_Larga.Large(palabra);

            Console.ReadKey();

        }
    }
}
