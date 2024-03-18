using System;

namespace ex01;

public class Exercicio01{

    public static double calculaEstoqueMedio(double estoqueMinimo, double estoqueMaximo)
    {
        double resultado = (estoqueMinimo + estoqueMaximo) / 2;
        return resultado;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(calculaEstoqueMedio(0, 0));
        Console.WriteLine(calculaEstoqueMedio(1, 1));
        Console.WriteLine(calculaEstoqueMedio(1, 2));
        Console.WriteLine(calculaEstoqueMedio(2, 9));
        Console.WriteLine(calculaEstoqueMedio(101, 102));
    }
}


