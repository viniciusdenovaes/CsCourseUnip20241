namespace ex02;

public class TesteCarro {
	
	static void Main(string[] args) {
		
		Pessoa dono = new Pessoa("Cormac", "McCarthy");
		Carro c01 = new Carro(dono, 2020);
		
		Console.WriteLine("\nCarro criado:");
		Console.WriteLine(c01);
		
		Cartorio.MudaDonoCarro(c01, new Pessoa("Philip", "Roth"));
		
		Console.WriteLine("\nDepois de mudar o dono com mudaDonoCarro:");
		Console.WriteLine(c01);
		
		Cartorio.MudaDono(c01.GetDono(), new Pessoa("Don", "DeLilo"));
		
		Console.WriteLine("\nDepois de mudar o dono com mudaDono:");
		Console.WriteLine(c01);
		
	}

}
