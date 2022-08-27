public class ejercicio12
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Ingrese el primer numero \n");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero \n");
        int num2 = int.Parse(Console.ReadLine());

        if (num2 != 0)
        {
            var resultado = num1 / num2;
            Console.WriteLine("El resultado de la division es : " + resultado);
        } else { 
            Console.WriteLine("Error No se puede dividir entre 0");
        }

    }


}