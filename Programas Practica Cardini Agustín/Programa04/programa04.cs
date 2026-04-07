﻿﻿namespace Programa04;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- BLOQUE 3: TEXTO Y CARACTERES ---");

            // Cadena de texto (string) - Comillas dobles ""
            string nombre = "Juan";
            string apellido="Lopez";
            Console.WriteLine($">>> TIPO TEXTO (string): {nombre} {apellido}");

            // Carácter único (char) - Comillas simples ''
            char inicialNombre = 'J';
            char inicialApell = 'L';
            Console.WriteLine($">>> TIPO CARÁCTER (char): {inicialNombre} - {inicialApell}");

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

    }
}