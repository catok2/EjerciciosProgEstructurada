public class ejercicio11
{

    public static void Main(String[] args)
    {
        Console.WriteLine("Ingrese el primer numero \n");

        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero \n");

        int numero2 = int.Parse(Console.ReadLine());

        if (numero1 > numero2)
        {
            Console.WriteLine("\n El numero 1 es mayor al numero 2");
        }
        else
            if (numero1 < numero2)
        {
            Console.WriteLine("\n El numero 2 es mayor al numero 1");
        }
        else
            Console.WriteLine("\n Los numeros son nulos");
         
        }
    }

