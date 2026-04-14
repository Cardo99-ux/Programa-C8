using System;

namespace GuiaArreglos
{
    class Ejercicio01
    {
        static void Main(string[] args)
        {
            //1.------------------------------
            Console.WriteLine("--- Ejercicio 1: Fundamentos de Arreglos ---\n");
            
            int[] numeros = new int[4];

            numeros[0]= 5;
            numeros[1]= 10;
            numeros[2]= 20;
            numeros[3]= 30;
            
            Console.WriteLine("--- Ejemplo 1 ---");
            Console.WriteLine("Valor en indice 0: " + numeros[0]);
            Console.WriteLine("Valor en indice 1: " + numeros[1]);
            Console.WriteLine("Valor en indice 2: " + numeros[2]);
            Console.WriteLine("Valor en indice 3: " + numeros[3]);

            //2.------------------------------
            string[] palabras = new string[4];

            palabras[0]="HOLA";
            palabras[1]="MUNDO,";
            palabras[2]="¿COMO";
            palabras[3]="ESTAN?";

            Console.WriteLine("\n--- Ejemplo 2 ---");
            Console.WriteLine($"\n{palabras[0]} {palabras[1]} {palabras[2]} {palabras[3]}");
          
            
            //3.-----------------------------
            double[] precios = new double[3];

            precios[0]=12.32;
            precios[1]=1.76;
            precios[2]=342.55;

            Console.WriteLine("\n--- Ejemplo 3 ---");
            Console.WriteLine($"\tPRECIOS\n\t${precios[0]}\n\t${precios[1]}\n\t${precios[2]}");
            
             //4.-----------------------------

             long[] telefonos = new long[3];

             telefonos[0]= 3401445566;
             telefonos[1]= 3888123212;
             telefonos[2]= 3441792456;

             Console.WriteLine("\n--- Ejemplo 4 ---");
             Console.WriteLine("--- TELEFONOS ---");
             Console.WriteLine($"User1:{telefonos[0]}\nUser2:{telefonos[1]}\nUser3:{telefonos[2]}");


             //5.-----------------------------
            char[] inicial = new char[3];

            inicial[0]= 'h';
            inicial[1]= 'o';
            inicial[2]= 'y';

            Console.WriteLine("\n--- Ejemplo 5 ---");
            Console.WriteLine($"{inicial[0]} {inicial[1]} {inicial[2]}");
             
            Console.WriteLine("\nPresione ENTER para salir...");
            Console.ReadLine();
            

        }
    }
}