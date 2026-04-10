﻿namespace Programa03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- BLOQUE 2: NÚMEROS CON DECIMALES ---");

            //1. Altura (double)
            double altura = 12.75;
            Console.WriteLine($"2. TIPO DECIMAL COMÚN (double): {altura}");
           //2. Promedio (double)
double nota1 = 7.5;
double nota2 = 8.0;
double nota3 = 6.5;

double promedio = (nota1 + nota2 + nota3) / 3;

Console.WriteLine("Promedio: " + promedio);
//3.Conversion Km a milla
double kilometros = 10.0;
double millas = kilometros * 0.621371;

Console.WriteLine("10 km equivalen a " + millas + " millas");

            //4. Dinero (decimal) - Recuerda la 'm' al final
            decimal precioProducto = 15999.34m;
            Console.WriteLine($"\n3. TIPO DECIMAL FINANCIERO (decimal): {precioProducto}");
//5.Calculo Perimetro Rectangulo
double largo = 5.2;
double ancho = 3.8;
double perimetro = 2 * (largo + ancho);

Console.WriteLine("Perímetro del rectángulo: " + perimetro);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

    }
}