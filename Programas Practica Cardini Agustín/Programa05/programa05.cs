﻿using System.Reflection.Metadata;

namespace Programa05;

class Program
{
    static void Main(string[] args)
    {
         // Booleano (bool) - Solo true o false
            bool verdadero = true;
            bool falso = false;
        Console.WriteLine($"--- BLOQUE 4: VALORES LÓGICOS ({verdadero} / {falso}) ---");//1

            Console.WriteLine($"Los valores booleanos se distinguen entre {verdadero} y {falso} , "); //2
            Console.WriteLine($"son la forma de dato primitivas de las computadoras");
            Console.WriteLine($"cuyo valor 1 indica {verdadero} y 0 indica {falso} "); //3
            Console.WriteLine(".__________________.");
            Console.WriteLine($"|1-->{verdadero}         |"); //4
            Console.WriteLine("|_________________|");
            Console.WriteLine($"|0-->{falso}        |"); //5
            Console.WriteLine("|_________________|");
           
           
            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

    }
}