namespace programaArreglo;

class Program
{
    static void Main(string[] args)
    {
       //Declaracion de variables.
       const int limite=3;  
       string[] nombres = new string[limite];
       int[] edades = new int[limite];

       //Insercion de Datos mediante FOR
       for(int i=0 ;i < limite; i++)
        {
            Console.Write($"<indice>[{i}] \n>> Ingresa nombre: ");
            nombres[i] = Console.ReadLine();
            Console.Write($">> Ingresa edad de {nombres[i]}: ");
            edades[i] = int.Parse(Console.ReadLine());

            //Validacion
            if(edades[i] > 30)
            {
                Console.WriteLine($">> {nombres[i]} DE {edades[i]} AÑOS PUEDE INGRESAR- ");
            }
            else
            {
                Console.WriteLine($">> {nombres[i]} DE  {edades[i]} AÑOS NO PUEDE INGRESAR");
            }
        }
       
     


            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();
    }
}