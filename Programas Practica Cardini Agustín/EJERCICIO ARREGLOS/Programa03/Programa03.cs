using System;

namespace GuiaArreglos
{
    class Ejercicio03
    {
        static void Main(string[] args)
        {
            //1.------------------------------
            Console.WriteLine("--- Ejercicio 3:Uso de .LENGTH y bucle FOR---\n");
            
            string[] citricos = { "Toronja" , "Mandarina" , "Pomelo" , "Limon"};

             Console.WriteLine("\nEjemplo 1:");
             int cantElementos= citricos.Length;
             Console.WriteLine($"Longitud Arreglo: {cantElementos} elementos. ");

             for(int i=0;i < citricos.Length; i++)
            {
                Console.WriteLine($"Indice [{i}] -> Citrico: {citricos[i]}");
            }

         
         //2.------------------------------
         int[] numeros = {12,23,15,32};

             Console.WriteLine("\nEjemplo 2:");
             int cantiElementos= numeros.Length;
             Console.WriteLine($"Longitud Arreglo: {cantiElementos} elementos. ");

             for(int i=0;i < numeros.Length; i++)
            {
                Console.WriteLine($"Indice [{i}] -> Número: {numeros[i]}");
            }
           
         //3.------------------------------
         double[] precios = {321.32 , 1981.45 , 1001.50 , 650.07};

             Console.WriteLine("\nEjemplo 3:");
             int cantidElementos= precios.Length;
             Console.WriteLine($"Longitud Arreglo: {cantidElementos} elementos. ");

             for(int i=0;i < precios.Length; i++)
            {
                Console.WriteLine($"Indice [{i}] -> Precio:$ {precios[i]}");
            }
           
         //4.------------------------------
         char[] letras = {'a', 'b' , 'c' , 'd'};

            Console.WriteLine("\nEjemplo 4:");
           int cantidaElementos= letras.Length;
             Console.WriteLine($"Longitud Arreglo: {cantidaElementos} elementos. ");

             for(int i=0;i < letras.Length; i++)
            {
                Console.WriteLine($"Indice [{i}] -> Letra: {letras[i]}");
            }

         //5.------------------------------
        long[] dnis = {44987654 , 21276454 , 11988212 , 41976432};

            Console.WriteLine("\nEjemplo 5:");
           int cantidadElementos= dnis.Length;
             Console.WriteLine($"Longitud Arreglo: {cantidadElementos} elementos. ");

             for(int i=0;i < dnis.Length; i++)
            {
                Console.WriteLine($"Indice [{i}] -> DNI: {dnis[i]}");
            }
        
           Console.WriteLine("\nPresiona ENTER para salir...");
           Console.ReadLine();

        }
    }
}