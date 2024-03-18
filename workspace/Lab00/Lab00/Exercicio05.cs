
using System;

namespace ex05;

public class Exercicio05{

    public static double calculaVolumeLata(double raio, double altura){
        return Math.PI * Math.Pow(raio, 2) * altura;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(calculaVolumeLata(1, 1));
        Console.WriteLine(calculaVolumeLata(2, 1));
        Console.WriteLine(calculaVolumeLata(1, 2));
        Console.WriteLine(calculaVolumeLata(1, 1 / Math.PI));
        Console.WriteLine(calculaVolumeLata(2, 1 / Math.PI));
        Console.WriteLine(calculaVolumeLata(10, 1));
        Console.WriteLine(calculaVolumeLata(1, 10));
        Console.WriteLine(calculaVolumeLata(10, 10));
    }
}
