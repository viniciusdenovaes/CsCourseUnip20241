
using System;

namespace ex08;

using ex07;

public class Exercicio08{

    public static int binomial(int n, int k){
        return Exercicio07.fatorial(n) / (Exercicio07.fatorial(k) * Exercicio07.fatorial(n-k));
    }

    static void Main(string[] args)
    {
        Console.WriteLine(binomial(0, 0));
        Console.WriteLine(binomial(1, 0));
        Console.WriteLine(binomial(1, 1));
        Console.WriteLine(binomial(2, 1));
        Console.WriteLine(binomial(5, 1));
        Console.WriteLine(binomial(2, 2));
        Console.WriteLine(binomial(5, 2));
        Console.WriteLine(binomial(10, 3));
    }
}
