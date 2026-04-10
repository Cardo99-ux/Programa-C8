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

//2.suma entre 2 números enteros
int a = 10;
int b = 20;
int suma = a + b;

Console.WriteLine("La suma es: " + suma);
//3.Cuadrado de dos números enteros
int numero = 7;
int cuadrado = numero * numero;

Console.WriteLine("El cuadrado de " + numero + " es: " + cuadrado);
//4.Division entre dos enteros
int dividendo = 25;
int divisor = 4;
int resultado = dividendo / divisor;

Console.WriteLine("Resultado de la división entera: " + resultado);



//5.Calcular modulo
int dividendo = 25;
int divisor = 4;
int resto = dividendo % divisor;

Console.WriteLine("El resto de la división es: " + resto);



            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

    }
}