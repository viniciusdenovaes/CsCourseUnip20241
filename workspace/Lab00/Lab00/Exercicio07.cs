
using System;

namespace ex07;

public class Exercicio07{

    public static int fatorial(int n){
        if (n == 0) { return 1; }
        else { return n*fatorial(n-1); }
    }

    static void Main(string[] args)
    {
        Console.WriteLine(fatorial(0));
        Console.WriteLine(fatorial(1));
        Console.WriteLine(fatorial(2));
        Console.WriteLine(fatorial(3));
        Console.WriteLine(fatorial(4));
        Console.WriteLine(fatorial(10));
    }
}
