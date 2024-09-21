using System;

namespace EJERCICIO2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
            //Luego recorrer ese vector para calcular el promedio. 
            //Mostrar por pantalla los valores que son mayores al promedio.

            int[] num = new int[10];
            float prom = 0;
            int cont = 0;


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un nro...");
                num[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                cont += num[i];
            }

            prom = cont / 10f;
            Console.WriteLine("El promedio es: " + prom);

            for (int i = 0; i < 10; i++)
            {
                if(num[i]>prom){
                    Console.Write(num[i] + " ");
                }
            }



        }
    }
}
