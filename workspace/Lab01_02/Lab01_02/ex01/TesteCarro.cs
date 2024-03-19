namespace ex01;

public class TesteCarro {
	
	static void Main(string[] args) {
		
		Carro c01 = new Carro("bmw", 2010, 10);
		
		Console.WriteLine("\nCarro criado:");
		Console.WriteLine(c01);
		
		Posto.AbastecerCarro(c01, 25);
		
		Console.WriteLine("\nDepois de abastecer com abastecerCarro:");
		Console.WriteLine(c01);
		
		Posto.AbastecerTanque(c01.GetTanque(), 25);
		
		Console.WriteLine("\nDepois de abastecer com abastecerTanque:");
		Console.WriteLine(c01);
		
	}

}
