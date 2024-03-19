namespace ex01;

public class TesteCarro {
	
	static void Main(string[] args) {
		Carro c1 = new Carro(new Modelo("bmw", 1990), 5, 50);
		Console.WriteLine(c1);
		
		Cartorio.MudaDono(c1, new Pessoa("Ana", "Beatriz"));
		
		for(int i=0; i<4; i++) {
			Posto.AbastecerCarro(c1, 20);
		}
		
		for(int i=0; i<4; i++) {
			double km = 80;
			Console.WriteLine("andando " + km);
			double kmAndado = c1.Anda(km);
			Console.WriteLine("conseguiu andar " + kmAndado);
			Console.WriteLine(c1);
			Console.WriteLine();
		}
		
	}

}
