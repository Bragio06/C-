using System;

public class teste
{
    public static void Main(string[] args)
    {   
        int numero;
        Console.WriteLine("Digite o primeiro numero");
        bool valor = int.TryParse(Console.ReadLine(), out numero);

        while (numero <= 200)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Digite um numero");
            int novoNumero = int.Parse(Console.ReadLine());
            numero += novoNumero;
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(numero);
            
             
            
        }
        Console.WriteLine("acabo");
        Console.ReadKey();
    }
}