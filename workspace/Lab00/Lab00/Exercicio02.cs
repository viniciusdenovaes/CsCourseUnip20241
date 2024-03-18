
using System;

namespace ex02;

public class Exercicio02{

    public static double conversaoDolar(double cotacaoDolar, double valorDolar)
    {
        return cotacaoDolar * valorDolar;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(conversaoDolar(1, 1));
        Console.WriteLine(conversaoDolar(0.5, 1));
        Console.WriteLine(conversaoDolar(0.5, 2));
        Console.WriteLine(conversaoDolar(2, 1));
        Console.WriteLine(conversaoDolar(5.37, 1));
        Console.WriteLine(conversaoDolar(5.37, 100));
        Console.WriteLine(conversaoDolar(5.37, 0.5));
    }
}
