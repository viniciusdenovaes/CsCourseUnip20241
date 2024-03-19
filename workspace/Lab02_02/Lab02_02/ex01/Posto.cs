namespace ex01;

public class Posto {
	
	public static void AbastecerCarro(Carro carro, double gasolina) {
		Console.WriteLine("Tentando abastecer " + gasolina + " no carro");
		Console.WriteLine(carro);
		
		double gasolinaAbastecida = carro.AddGasolina(gasolina);
		
		Console.WriteLine("Abastecido " + gasolinaAbastecida + " no carro");
		Console.WriteLine(carro);
		
	}

}
