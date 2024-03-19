namespace ex01;

public class TanqueDeGasolina {
	
	private double quantidadeGasolina;
	private double limiteGasolina;
	
	public TanqueDeGasolina(double quantidadeGasolina, double limiteGasolina) {
		this.quantidadeGasolina = quantidadeGasolina;
		this.limiteGasolina = limiteGasolina;
	}

	public double GetQuantidadeGasolina() {
		return quantidadeGasolina;
	}

	public double GetLimiteGasolina() {
		return limiteGasolina;
	}
	
	public double AumentaGasolina(double gasolina) {
		double gasolinaResultante = Math.Min(this.quantidadeGasolina+gasolina, this.limiteGasolina);
		double gasolinaGanha = gasolinaResultante - this.quantidadeGasolina;
		this.quantidadeGasolina = gasolinaResultante;
		return gasolinaGanha;
	}
	
	public double GastarGasolina(double gasolina) {
		double gasolinaGasta = Math.Min(gasolina, this.quantidadeGasolina);
		this.quantidadeGasolina -= gasolinaGasta;
		return gasolinaGasta;
	}

	
	public override string ToString() {
		return "TanqueDeGasolina [quantidadeGasolina=" + quantidadeGasolina + ", limiteGasolina=" + limiteGasolina
				+ "]";
	}
	
	

}
