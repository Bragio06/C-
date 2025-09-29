using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        FileStream meuarq = new FileStream("dados.txt", FileMode.Open, FileAccess.Write);

        StreamWriter str = new StreamWriter(meuarq, Encoding.UTF8);

        string sr = string.Empty;

        while (sr != "sair")
        {
            Console.WriteLine("Digite uma linha (ou 'sair' para terminar):");
            sr = Console.ReadLine();
            str.WriteLine(sr);
        }
        str.Close();
        meuarq.Close();

        
    }
}