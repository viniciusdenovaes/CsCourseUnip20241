
using System;

namespace ex06;

public class Exercicio06{

    public static int modulo(int n){
        if (n > 0) { return n; }
        else { return -n; }
    }

    static void Main(string[] args)
    {
        Console.WriteLine(modulo(1));
        Console.WriteLine(modulo(0));
        Console.WriteLine(modulo(-1));
        Console.WriteLine(modulo(2));
        Console.WriteLine(modulo(-2));
    }
}
