using System;

namespace EJEMPLO_VECTORES
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vectores/array/arreglo
            int n;
            int[] numeros = new int[10];

            //  0 1 2 3 4 5 6 7 8 9
            // | | | | | | | | | | |

            // numeros[6] = 1;
            // numeros[0] = 7;
            // numeros[9] = 32450;

            // a = numeros[6]+numeros[0]+numeros[9];

            // Console.WriteLine(a);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese la nota: ");
                n = int.Parse(Console.ReadLine());
                numeros[i] = n;

            }
            int acum = 0;
            for (int i = 0; i < 10; i++)
            {
                acum += numeros[i];
            }

            int prom;

            prom = acum/10;

            Console.WriteLine("El promedio es: " + prom);

        }
    }
}
