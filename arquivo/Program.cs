
using System;

public class ARQUIVO
{
    FileStream arq = new FileStream("dados.txt", fileMode.Open, FileAccess.Read);
    StreamReader sr = new StreamReader(arq, Encoding.UTF8);

    string str;
    int soma = 0;
    while (!string.EndOfStream)
    {
       str = sr.ReadLine();
    }
}