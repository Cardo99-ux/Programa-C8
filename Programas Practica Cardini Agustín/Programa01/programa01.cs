namespace Programa01;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("--- SISTEMA DE REGISTRO DE PRODUCTOS ---");
       Console.WriteLine("__________________________________________");

            // 1. Entrada de Texto
            Console.Write("Ingresa nombre del producto: ");
            string producto = Console.ReadLine();
            Console.Write("Ingresa categoria del producto: ");
            string codigo = Console.ReadLine();

            // 2. Entrada de Números
            Console.Write("Ingresa stock: ");
            int stock = int.Parse(Console.ReadLine()); 

            // 3. Entrada de Decimales 
            Console.Write("Ingresa precio unitario(ej:$1500,75):$ ");
            double precio = double.Parse(Console.ReadLine()); // Conversión directa en una línea

            // 4. Mostrar los resultados procesados
            Console.WriteLine("\n--- PRODUCTO INGRESADO---");
            Console.WriteLine("PRODUCTO: " + producto);
            Console.WriteLine("CATEGORÍA: " + codigo); 
            Console.WriteLine("PRECIO UNITARIO:$ " + precio);
            Console.WriteLine("STOCK DISPONIBLE: " +stock);
            Console.WriteLine("PRECIO TOTAL STOCK:$ " + precio * stock);

//5.fin del programa
            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();
    }
}