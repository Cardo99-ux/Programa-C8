﻿using System.Reflection.Metadata;

namespace Programa05;

class Program
{
    static void Main(string[] args)
    {
         //1. Booleano (bool) - Solo true o false
            bool verdadero = true;
            bool falso = false;
        Console.WriteLine($"--- BLOQUE 4: VALORES LÓGICOS ({verdadero} / {falso}) ---");

            Console.WriteLine($"Los valores booleanos se distinguen entre {verdadero} y {falso} , ");
            Console.WriteLine($"son la forma de dato primitivas de las computadoras");
            Console.WriteLine($"cuyo valor 1 indica {verdadero} y 0 indica {falso} "); 
            Console.WriteLine(".__________________.");
            Console.WriteLine($"|1-->{verdadero}         |"); 
            Console.WriteLine("|_________________|");
            Console.WriteLine($"|0-->{falso}        |");
            Console.WriteLine("|_________________|");
           
//2 ejemplo 
int numero = 5;
bool esPositivo = numero > 0;

Console.WriteLine("¿El número es positivo? " + esPositivo);

//3. ejemplo 
int edad = 20;
bool esMayorDeEdad = edad >= 18;

Console.WriteLine("¿Es mayor de edad? " + esMayorDeEdad);

//4.ejemplo
bool luzRoja = true;
bool luzVerde = false;

if (luzRoja)
{
    Console.WriteLine("Detenerse");
}
else if (luzVerde)
{
    Console.WriteLine("Avanzar");
}
//5.ejemplo
bool tieneUsuario = true;
bool tieneContraseña = false;

bool accesoPermitido = tieneUsuario && tieneContraseña;

Console.WriteLine("Acceso al sistema: " + accesoPermitido);
           
            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

    }
}