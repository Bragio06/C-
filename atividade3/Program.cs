using System;

public class teste
{
    public static void Main(string[] args)
    {   
        int m,n;
        int produtom = 1;
        int produton = 1;

        Console.WriteLine("Digite o numero minimo");
        bool minimo = int.TryParse(Console.ReadLine(), out m);
        int gurdaMinimo = m;
        
        Console.WriteLine("Digite o numero maximo");
        bool maximo = int.TryParse(Console.ReadLine(), out n);

        while (m <= n)
        {
            Console.WriteLine("-----------");
            Console.WriteLine(m);
            produtom = produtom * m;
            m++;
  
        }
            
        while (n >= gurdaMinimo)
        {
            produton = produton * n;
            Console.WriteLine("-----------");
            Console.WriteLine(n);
            n--;
        }        

        int resultado = produton * produtom;
        Console.WriteLine(resultado);
        Console.ReadKey();
    }
}