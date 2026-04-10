﻿﻿namespace Programa04;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- BLOQUE 3: TEXTO Y CARACTERES ---");

            //1. Cadena de texto (string) - Comillas dobles ""
            string nombre = "Juan";
            string apellido="Lopez";
            Console.WriteLine($">>> TIPO TEXTO (string): {nombre} {apellido}");
           //2.Recorrer un string
string palabra = "Hola";

foreach (char c in palabra)
{
    Console.WriteLine("Char: " + c);
}

            //3. Carácter único (char) - Comillas simples ''
            char inicialNombre = 'J';
            char inicialApell = 'L';
            Console.WriteLine($">>> TIPO CARÁCTER (char): {inicialNombre} - {inicialApell}");
            //4. Char y codigo ASCII
char letra = 'A';
int codigoAscii = (int)letra;
            //5. Concatenacion de Chars
char letra1 = 'H';
char letra2 = 'O';
char letra3 = 'L';
char letra4 = 'A';

string palabra = "" + letra1 + letra2 + letra3 + letra4;

Console.WriteLine("Palabra formada: " + palabra);

Console.WriteLine("La letra es: " + letra);
Console.WriteLine("Su código ASCII es: " + codigoAscii);



            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

    }
}