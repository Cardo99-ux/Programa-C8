﻿namespace Programa03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- BLOQUE 2: NÚMEROS CON DECIMALES ---");

            // Altura (double)
            double altura = 12.75;
            Console.WriteLine($"2. TIPO DECIMAL COMÚN (double): {altura}");
           

            // Dinero (decimal) - Recuerda la 'm' al final
            decimal precioProducto = 15999.34m;
            Console.WriteLine($"\n3. TIPO DECIMAL FINANCIERO (decimal): {precioProducto}");

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

    }
}