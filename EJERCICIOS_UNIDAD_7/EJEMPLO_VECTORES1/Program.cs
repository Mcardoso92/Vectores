using System;

namespace EJEMPLO_VECTORES1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo con DOUBLE

            double[] muestraMatutina = new double[31];
            double[] muestraVespertina = new double[31];
            double[] muestraNocturna = new double[31];

            //cruce
            //Registro Matutino
            int dia;
            double temperatura;
            Console.WriteLine("Cargue el registro matutino")
            for (int i = 0; i < 31; i++)
            {
                Console.WriteLine("Ingrese dia: ");
                dia = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese temperatura registrada");
                temperatura = double.Parse(Console.ReadLine());

                muestraMatutina[dia - 1] = temperatura;
                
            }

            for (int i = 0; i < 31; i++)
            {
                
            }

            for (int i = 0; i < 31; i++)
            {
                
            }


        }
    }
}
