namespace ex01;

public class Posto {
	
	public static void AbastecerCarro(Carro carro, double qtdGas) {
		carro.SetTanque(carro.GetTanque()+qtdGas);
	}
	
	public static void AbastecerTanque(double tanque, double qtdGas) {
		tanque += qtdGas;
	}
	
}
