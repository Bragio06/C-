using System;

public class teste
{
    public static void Main(string[] args)
    {
        int quntidade = 2;
        int matricula;
        double media = 0;
        double n1, n2;

        for (int i = 0; i <= quntidade; i++)
        {
            Console.WriteLine("Digite o numero da matricula do " + (1+ i) + " aluno");
            bool facudadde = int.TryParse(Console.ReadLine(), out matricula);
            for (int j = 0; j < 1; j++)
            {

                Console.WriteLine("Digite a nota da n1 do " + (1+ i) + " aluno");
                bool notaN1 = double.TryParse(Console.ReadLine(), out n1);


                Console.WriteLine("Digite a nota da n2 do " + (1+ i) + " aluno");
                bool notaN2 = double.TryParse(Console.ReadLine(), out n2);

                media = (n1 + n2) / 2;
            }
            Console.WriteLine("A media do " + i + " aluno foi " + media);
            Console.WriteLine("--------------------------------------------");
            media = 0;
            n1 = 0;
            n2 = 0;
        }
        ;
        Console.WriteLine("Acabou");
    }
}