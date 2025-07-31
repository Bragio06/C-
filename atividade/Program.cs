using System;

public class ReceberDados
{
    public static void Main(string[] args)
    {
        Console.Write("Digite seu nome:");
        string nome = Console.ReadLine();


        Console.WriteLine("Qual foi a sua nota da primeira prova?");
        double N1 = Convert.ToDouble(Console.ReadLine());    

        
        Console.WriteLine("Qual foi a sua nota do primeira trabalho?");
        double TrabalhoN1 = Convert.ToDouble(Console.ReadLine());


        
        Console.WriteLine("Qual foi a sua nota da primeira prova");
        double N2 = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Qual foi a sua nota da primeira prova");
        double TrabalhoN2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("-----------------------------------------------------------");

        double soma = ((N1 * 0.7) + (TrabalhoN1 * 0.3) + (N2 * 0.7) + (TrabalhoN2 * 0.3)) / 2;

        if (soma >= 7)
        {
            Console.WriteLine("O aluno " + nome + " foi aprovado!!");
            Console.WriteLine("sua nota foi: " + soma);

        }
        else if (soma < 7 && soma >= 3)
        {
            Console.WriteLine("O aluno " + nome + " esta de recuperação!!");
            Console.WriteLine("sua nota foi: " + soma);
        }
        else
        {
            Console.WriteLine("O aluno " + nome + " foi reprovado!!");
            Console.WriteLine("sua nota foi: " + soma);

        }

    }
}


