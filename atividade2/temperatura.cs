using System;

public class ReceberDados
{
    public static void Main(string[] args)
    {
        int resposta;
        double celsius, fahrenheit, kelvin, rankine;

        Console.WriteLine("Digite qual temperatura voce quer converter?");
        Console.WriteLine("Digite 1 para celsius ; 2 para fahrenheit; 3 para kelvin; 4 para rankine:");
        resposta = int.TryParse(Console.ReadLine(), out resposta);
        
        switch (resposta)
        {
            case 1:
                Console.WriteLine("Digite a teperatura em celsius:");
                celsius = Convert.ToDouble(Console.ReadLine());
                rankine = (celsius * 9 / 5) + 491.67;
                fahrenheit = (celsius * 9 / 5) + 32;
                kelvin = celsius + 273.15;
                Console.WriteLine("kelvin:" + kelvin);
                Console.WriteLine("rankine:" + rankine);
                Console.WriteLine("fahrenheit:" + fahrenheit);
                break;
            case 2:
                Console.WriteLine("Digite a teperatura em fahrenheit:");
                fahrenheit = Convert.ToDouble(Console.ReadLine());

                rankine = fahrenheit + 459.67;
                celsius = (fahrenheit - 32) * 5 / 9;
                kelvin = (fahrenheit - 32) * 5 / 9 + 273.15;

                Console.WriteLine("kelvin:" + kelvin);
                Console.WriteLine("rankine:" + rankine);
                Console.WriteLine("celsius:" + celsius);
                break;
            case 3:
                Console.WriteLine("Digite a teperatura em kelvin:");
                kelvin = Convert.ToDouble(Console.ReadLine());

                rankine = kelvin * 1.8;
                celsius = kelvin - 273.15;
                fahrenheit = (kelvin - 273.15) * 9 / 5 + 32;

                Console.WriteLine("celsius:" + celsius);
                Console.WriteLine("rankine:" + rankine);
                Console.WriteLine("fahrenheit:" + fahrenheit);
                break;
            case 4:
             Console.WriteLine("Digite a teperatura em rankine:");
                rankine = Convert.ToDouble(Console.ReadLine());

                kelvin = rankine * 5 / 9;
                celsius = (rankine - 491.67) * 5 / 9;
                fahrenheit = rankine - 459.67;

                Console.WriteLine("kelvin:" + kelvin);
                Console.WriteLine("celsius:" + celsius);
                Console.WriteLine("fahrenheit:" + fahrenheit);
                break;
            
        }



       

    }
}


