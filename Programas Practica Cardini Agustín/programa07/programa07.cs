﻿using System.Security.Cryptography;

namespace Programa07;

class Program
{
    static void Main(string[] args)
    {

            //1 --- Constante de Login ---
            const string CLAVE_SECRETA = "admin123";
            const string usuario = "admin";  
             
            Console.WriteLine("--- SISTEMA DE ACCESO ---");
            Console.WriteLine("Ingrese el nombre de usuario:");
            string usuarioIngresado = Console.ReadLine();
            
            if(usuarioIngresado==usuario)
            {
            Console.WriteLine("\nIngrese la clave para acceder al sistema:"); 
            string claveIngresada = Console.ReadLine();
            Console.WriteLine(claveIngresada==CLAVE_SECRETA?"clave correcta":"clave incorrecta");
            }
             else
            {
            Console.WriteLine("Usuario Incorrecto");
            }
            
            //2 --- Constante conversion de moneda de dolares a pesos --
            const char SIMBOLO_PESO = '$';
            const decimal dolarApeso = 1400.15m;
            Console.Write($"\nIngrese el monto en dólares a convertir:{SIMBOLO_PESO} ");
            decimal monto = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Conversión: {SIMBOLO_PESO} {monto} USD = {SIMBOLO_PESO} {monto * dolarApeso} ARS");

            //3 --- constante de formula de área de un circulo ---
            const double PI = 3.1416;
            Console.Write("\nIngrese el radio del círculo para calcular su área: ");
            double radio = double.Parse(Console.ReadLine());
            double areaCirculo = PI * Math.Pow(radio, 2);
            Console.WriteLine($"El área del círculo con radio {radio} es: {areaCirculo}");

            //4 --- constante booleano para encuesta ---
            const bool SI = true;
            const bool NO = false;
            Console.WriteLine("\n¿Le gusta la programación? (si/no)");
            string respuesta = Console.ReadLine().ToLower();
            if (respuesta == "si") 
            {Console.WriteLine($"{SI} -Te gusta la programacion");
            }
            else if(respuesta == "no")
            {
            Console.WriteLine( $"{NO} -No te gusta la programación");
            }
             else
             {
            Console.WriteLine("Respuesta no valida");
             }
           
             //5 --- constante de fecha ---
             const int dia= 9;
             const int mes= 4;
             const int año=2026;
             
             Console.WriteLine($"\nFECHA: {dia}/{mes}/{año}");




            Console.WriteLine("\n--- FIN DEL PROGRAMA ---");
            Console.ReadLine();     

    }
}