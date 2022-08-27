public class ejercicio9
{

    public static void Main(String[] args)
    {
        Console.Write(" INGRESE DATOS \n \n");
        Console.Write(" INGRESE NUMERO1 \n ");
        int numero1 = int.Parse(Console.ReadLine());
        Console.Write(" INGRESE NUMERO2 \n ");
        int numero2 = int.Parse(Console.ReadLine());
        int producto = numero1 * numero2;
        Console.WriteLine("El producto entre los numeros es : " + producto);
    }
}