
using System;

namespace ex03;

public class Exercicio03{

    public static double conversorCelsiusToFahrenheit(double grauC){
        return (9*grauC+160) / 5;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(conversorCelsiusToFahrenheit(0));
        Console.WriteLine(conversorCelsiusToFahrenheit(1));
        Console.WriteLine(conversorCelsiusToFahrenheit(2));
        Console.WriteLine(conversorCelsiusToFahrenheit(20));
        Console.WriteLine(conversorCelsiusToFahrenheit(39));
        Console.WriteLine(conversorCelsiusToFahrenheit(40));
        Console.WriteLine(conversorCelsiusToFahrenheit(100));
    }
}
