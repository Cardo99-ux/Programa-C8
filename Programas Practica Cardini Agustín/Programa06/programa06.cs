﻿﻿namespace Programa06;

class Program
{
    static void Main(string[] args)
    {
            //1. CONSTANTES MATEMATICAS
            const double pi= 3.14;
            const double e = 2.71;
            const double phi = 1.61;

            Console.WriteLine("=== Constantes Matemáticas ===");
            Console.WriteLine("Pi: " + pi);
            Console.WriteLine("e: " + e);   
            Console.WriteLine("Phi: " + phi);
 
            //2. CONSTANTES DE DATOS CONFIGURACION
            const string APP= "Sistema de Control de Inventarios";
            const int VERSION_APP = 1;
            const int MAX_PRODUCTOS = 1000;
            
            Console.WriteLine("\n=== Configuración de la Aplicación ===");
            Console.WriteLine("Nombre App: " + APP);
            Console.WriteLine("Versión: " + VERSION_APP);
            Console.WriteLine("Máximo de Productos: " + MAX_PRODUCTOS);

            //3.CONSTANTES PRECIOS (SIN ESTRUCTURAS DE CONTROL)
            const int precio = 1001;
            const int precio_maximo = 1000;
            const bool precio_valido = precio < precio_maximo;

            Console.WriteLine("\n=== Validación de Precio ===");
            Console.WriteLine("Precio: " + precio);
            Console.WriteLine("Precio Máximo: " + precio_maximo);
            Console.WriteLine("Precio válido : " + precio_valido);

            //4. CONSTANTES DE DATOS DE USUARIOS
            const string usuario = "Juan Doe";
            const string provincia = "Tucumán";
            const long telefono = 381234567;
  
            Console.WriteLine("\n=== Datos del Usuario ===");
            Console.WriteLine("Usuario: " + usuario);
            Console.WriteLine("Provincia: " + provincia);
            Console.WriteLine("Teléfono: " + telefono);

           //5. CONSTANTES DIAS DE LA SEMANA
            const string dia1 = "Lunes";
            const string dia2 = "Martes";
            const string dia3 = "Miércoles";
            const string dia4 = "Jueves";
            const string dia5 = "Viernes";
            const string dia6 = "Sábado";
            const string dia7 = "Domingo";
            
            Console.WriteLine("\n=== Días de la Semana ==="); //aqui uso operador ternario para mostrar el día seleccionado por usuario
            Console.Write("Inserte el número del día de la semana (1-7): ");
            int numeroDia = int.Parse(Console.ReadLine());
            Console.WriteLine("Día seleccionado: " + (numeroDia == 1 ? dia1 :
                                        numeroDia == 2 ? dia2 :
                                        numeroDia == 3 ? dia3 :
                                        numeroDia == 4 ? dia4 :
                                        numeroDia == 5 ? dia5 :
                                        numeroDia == 6 ? dia6 :
                                        numeroDia == 7 ? dia7 : "Numero invalido"));

            Console.WriteLine("\n=== Fin del Programa ===");
            Console.ReadLine();

    }
}