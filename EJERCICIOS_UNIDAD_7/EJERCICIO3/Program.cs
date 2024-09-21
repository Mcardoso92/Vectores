using System;

namespace EJERCICIO3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
            //El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan 
            //sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
            //CADENA FUENTE: “La mar estaba serena"
            //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            //CADENA RESULTADO: “Li mir estibi sereni"

            // char[] frase = new char[30];
            // char c1, c2, letra;
            // int i = 0;

            // Console.WriteLine("Ingrese un caracter: ");
            // c1 = char.Parse(Console.ReadLine());

            // Console.WriteLine("Ingrese otro caracter: ");
            // c2 = char.Parse(Console.ReadLine());
            
            // Console.WriteLine("Ingrese una letra: ");
            // letra = char.Parse(Console.ReadLine());
            // while (letra != '0' && i < 30)
            // {
            //     frase[i] = letra;
            //     Console.WriteLine("Ingrese otra letra: ");
            //     letra = char.Parse(Console.ReadLine());
            //     i++;
            // }
            // frase[i] = '\0';
            // i = 0;

            // while(frase[i] != '\0')
            // {
            //     if(frase[i] == c1)
            //         frase[i] = c2;
            //     i++;
            // }
            // i = 0;

            // while(frase[i] != '\0')
            // {
            //     Console.Write(frase[i]);
            //     i++;
            // }

            string frase;
            char letraActual;
            char letraNueva;

            Console.WriteLine("Ingrese la frase: ");
            frase = Console.ReadLine();
            Console.WriteLine("Ingrese la letra a reemplazar");
            letraActual = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la letra nueva");
            letraNueva = char.Parse(Console.ReadLine());

            frase = frase.Replace(letraActual,letraNueva);

            Console.WriteLine("La cadena nueva es: ");
            Console.WriteLine(frase);




        }
    }
}
