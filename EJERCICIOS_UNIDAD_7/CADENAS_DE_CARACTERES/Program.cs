using System;

namespace CADENAS_DE_CARACTERES
{
    class Program
    {
        static void Main(string[] args)
        {
            //CADENAS DE CARACTERES
            //char[] cadena = new char[10];

            //CADENA DE CARACTERES (FRASES)
            //VECTOR DE CHAR (LETRAS)
            
            //CARGAR Y MOSTRAR NOMBRE A BAJO NIVEL
            //CARGAR NOMBRE
            char[] nombre = new char[11];
            char letra;
            int indice = 0;

            Console.WriteLine("Ingrese su nombre letra por letra... (termina con punto)");
            letra = char.Parse(Console.ReadLine());
            while(letra != '.' && indice < 10){
                nombre[indice] = letra;
                letra = char.Parse(Console.ReadLine());
                indice++;
            }
            if(indice == 10)
                indice--;

            nombre[indice]= '\0';

            //Console.WriteLine("Hola " + nombre);

            //MOSTRAR NOMBRE
            // Console.Write("Hola ");
            // indice = 0;
            // while(nombre[indice] != '\0'){
            //     Console.Write(nombre[indice]);
            //     indice++;
            // }

            // string nombre;
            // Console.WriteLine("Ingrese su nombre...");
            // nombre = Console.ReadLine();
            // Console.WriteLine("Hola " + nombre);


        }
    }
}
