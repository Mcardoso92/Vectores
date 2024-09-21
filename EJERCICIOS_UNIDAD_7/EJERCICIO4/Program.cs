using System;

namespace EJERCICIO4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una empresa comercializa 15 tipos de artículos y por cada venta 
            //realizada genera un registro con los siguientes datos:
            //- Número de Artículo (1 a 15)
            //- Cantidad Vendida 

            //Puede haber varios registros para el mismo artículo y el último se indica 
            //con número de artículo igual a 0.
            //Se pide determinar e informar:
            //a) El número de artículo que más se vendió en total.
            //b) Los números de artículos que no registraron ventas.
            //c) Cuantas unidades se vendieron del número de artículo 10.

            int nroArt;
            int cantidad;
            int[] cantidadVendida = new int[15];
            int masVendido = 0;

            for (int i = 0; i < 15; i++)
            {
                cantidadVendida[i] = 0;
            }

            Console.WriteLine("Ingrese el nro de articulo");
            nroArt = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida");
            cantidad = int.Parse(Console.ReadLine());

            while(nroArt != 0){
                
                cantidadVendida[nroArt-1] += cantidad;
                
                
                Console.WriteLine("Ingrese el nro de articulo");
                nroArt = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad vendida");
                cantidad = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 15; i++)
            {
                if(i == 0)
                    masVendido = i+1;
                else{
                    if(cantidadVendida[i] > masVendido)
                        masVendido = i+1;
                }

                if(cantidadVendida[i] == 0){
                    Console.WriteLine("No se registraron ventas del articulo: " + (i+1));
                }
            }

            Console.WriteLine("El articulo mas vendido es el nro: " + (masVendido));
            Console.WriteLine("Se registraron " + cantidadVendida[9] + " del articulo nro 10");




        }
    }
}
