namespace ex01;

public class Cartorio {
	
	public static void MudaDono(Carro carro, Pessoa novoDono) {
		Console.WriteLine("mudando dono do carro ");
		Console.WriteLine(carro);
		Console.WriteLine("para novo dono " + novoDono);
		carro.SetDono(novoDono);
		
		Console.WriteLine("\nResultado: ");
		Console.WriteLine(carro);
	}

}
