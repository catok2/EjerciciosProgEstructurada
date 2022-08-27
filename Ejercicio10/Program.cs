using System.Security.Cryptography.X509Certificates;

public class ejercicio10{

    public static void Main(String[] args)
    {
        Console.WriteLine("Ingrese el numero \n");
        int numero1 = int.Parse(Console.ReadLine());

        if (numero1 % 2 == 0) {

            Console.WriteLine("\n El numero es par");
        }else
        {
            Console.WriteLine("\n El numero es impar");

        }        
    }
}