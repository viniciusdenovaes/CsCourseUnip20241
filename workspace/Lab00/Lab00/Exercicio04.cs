
using System;

namespace ex04;

public class Exercicio04{

    public static double conversorFahrenheitToCelsius(double grauF){
        return (grauF-32)* 5/9;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(conversorFahrenheitToCelsius(0));
        Console.WriteLine(conversorFahrenheitToCelsius(1));
        Console.WriteLine(conversorFahrenheitToCelsius(2));
        Console.WriteLine(conversorFahrenheitToCelsius(20));
        Console.WriteLine(conversorFahrenheitToCelsius(32));
        Console.WriteLine(conversorFahrenheitToCelsius(40));
        Console.WriteLine(conversorFahrenheitToCelsius(100));
    }
}
