﻿namespace Programa02;

class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine("--- BLOQUE 1: NÚMEROS ENTEROS ---");

            // Declaración de un entero
            int rojos = 409;
            Console.Write("ingrese cantidad verdes: ");
            int verdes = int.Parse(Console.ReadLine());
            Console.WriteLine($"Cantidad rojos: {rojos} y cantidad verdes {verdes}");
            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

    }
}