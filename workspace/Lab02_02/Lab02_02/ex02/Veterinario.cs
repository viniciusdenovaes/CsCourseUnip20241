namespace ex02;

public class Veterinario {

	public static void cuidaDoCachorro(Cachorro cachorro) {
		Console.WriteLine("Recebendo " + cachorro.GetNome());
		if(!cachorro.GetIsDoente()) {
			Console.WriteLine("O cachorro está saudável");
			Console.WriteLine("...");
			return;
		}

		Console.WriteLine("Dando injeção para o animalzinho");
		cachorro.DarInjecao();
		cachorro.Latir();
		cachorro.Comer();
		cachorro.Dormir();
		Console.WriteLine("saindo do veterinario");
		Console.WriteLine("...");
	}

	public static void cuidaDoGato(Gato gato) {
		Console.WriteLine("Recebendo " + gato.GetNome());
		if(!gato.GetIsDoente()) {
			Console.WriteLine("O gato está saudável");
			Console.WriteLine("...");
			return;
		}

		Console.WriteLine("Dando injeção para o animalzinho");
		gato.DarInjecao();
		gato.Miar();
		gato.Comer();
		gato.Dormir();
		Console.WriteLine("saindo do veterinario");
		Console.WriteLine("...");
	}

	public static void cuidaDoPato(Pato pato) {
		Console.WriteLine("Recebendo " + pato.GetNome());
		if(!pato.GetIsDoente()) {
			Console.WriteLine("O pato está saudável");
			Console.WriteLine("...");
			return;
		}

		Console.WriteLine("Dando injeção para o animalzinho");
		pato.DarInjecao();
		pato.Quack();
		pato.Comer();
		pato.Dormir();
		Console.WriteLine("saindo do veterinario");
		Console.WriteLine("...");
	}

}