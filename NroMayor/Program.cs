using System;

namespace EJERCICIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
            //Luego recorrer los elementos y determinar e informar cuál es el valor máximo 
            //y su posición dentro del vector.

            int[] num = new int[10];
            int max = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un nro...");
                num[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if(i == 0)
                    max = num[i];
                else{
                    if(num[i] > max)
                        max = num[i];
                }
            }

            Console.WriteLine("El mayor numero de los ingresados es: " + max);


        }
    }
}
