namespace ex02;

public class Cartorio {
	
	public static void MudaDonoCarro(Carro carro, Pessoa novoDono) {
		carro.SetDono(novoDono);
	}

	public static void MudaDono(Pessoa donoAntigo, Pessoa novoDono) {
		donoAntigo = novoDono;
	}
}
