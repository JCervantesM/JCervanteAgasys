using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Votos
    {
        public static void Voto()
        {
            int raul = 0;
            int alfonso = 0;
            int matias = 0;

            for (int i = 0; i < 13; i++)
            {
                int voto;
                Console.WriteLine("Por quien Votas \n 1.- Raul \n 2.- Alfonso \n 3.- Matias");
                voto = int.Parse(Console.ReadLine());

                if (voto == 1)
                {
                    raul = raul + 1;
                }
                else if (voto == 2)
                {
                    alfonso = alfonso + 1;
                }
                else if (voto == 3)
                {
                    matias = matias + 1;
                }
                Console.Clear();
            }
            if (raul > alfonso && raul > matias && alfonso > matias)
            {
                Console.WriteLine("Raul es el numero 1 con la cantidad de votos de: " + raul);
                Console.WriteLine("Alfonso es el numero 2 con la cantidad de votos de: " + alfonso);
                Console.WriteLine("Matias es el numero 3 con la cantidad de votos de: " + matias);
            }
            else if (raul > alfonso && raul > matias && matias > alfonso)
            {
                Console.WriteLine("Raul es el numero 1 con la cantidad de votos de: " + raul);
                Console.WriteLine("Matias es el numero 2 con la cantidad de votos de: " + matias);
                Console.WriteLine("Alfonso es el numero 3 con la cantidad de votos de: " + alfonso);
            }
            else if (alfonso > raul && alfonso > matias && matias > raul)
            {
                Console.WriteLine("Alfonso es el numero 1 con la cantidad de votos de: " + alfonso);
                Console.WriteLine("Matias es el numero 2 con la cantidad de votos de: " + matias);
                Console.WriteLine("Raul es el numero 3 con la cantidad de votos de: " + raul);
            }
            else if (alfonso > raul && alfonso > matias && raul > matias)
            {
                Console.WriteLine("Alfonso es el numero 1 con la cantidad de votos de: " + alfonso);
                Console.WriteLine("Raul es el numero 2 con la cantidad de votos de: " + raul);
                Console.WriteLine("Matias es el numero 3 con la cantidad de votos de: " + matias);
            }
            else if (matias > raul && matias > alfonso && raul > alfonso)
            {
                Console.WriteLine("Matias es el numero 1 con la cantidad de votos de: " + matias);
                Console.WriteLine("Raul es el numero 2 con la cantidad de votos de: " + raul);
                Console.WriteLine("Alfonso es el numero 3 con la cantidad de votos de: " + alfonso);
            }
            else if (matias > raul && matias > alfonso && alfonso > raul)
            {
                Console.WriteLine("Matias es el numero 1 con la cantidad de votos de: " + matias);
                Console.WriteLine("Alfonso es el numero 2 con la cantidad de votos de: " + alfonso);
                Console.WriteLine("Raul es el numero 3 con la cantidad de votos de: " + raul);
            }
            Console.ReadKey();

        }
    }
}
