namespace ex02;

public class TestaCuidador {
	
	static void Main(string[] args) {
		Cuidador cuidador = new Cuidador("Billy");
		
		cuidador.AddCachorro(new Cachorro("Brutus", 5, 2));
		cuidador.AddCachorro(new Cachorro("Rex", 15, 20));
		
		cuidador.AddGato(new Gato("Chirriro", 12, 5));
		cuidador.AddGato(new Gato("Xitara", 7, 2));
		
		Console.WriteLine(cuidador);
		Console.WriteLine();
		
		foreach(Cachorro c in cuidador.GetCachorros()) {
			c.Adoecer();
		}
		
		Console.WriteLine(cuidador);
		Console.WriteLine();
		
		foreach(Cachorro c in cuidador.GetCachorros()) {
			Veterinario.cuidaDoCachorro(c);
		}
		
		foreach(Gato g in cuidador.GetGatos()) {
			Veterinario.cuidaDoGato(g);
		}
		
		foreach(Pato p in cuidador.GetPatos()) {
			Veterinario.cuidaDoPato(p);
		}
		
		
	}

}
