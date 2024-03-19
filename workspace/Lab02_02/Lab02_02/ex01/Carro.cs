namespace ex01;

public class Carro {
	
	private Pessoa dono;
	private Modelo modelo;
	private TanqueDeGasolina tanque;
	private double distanciaPorLitro;
	private double kilometragem = 0;
	
	public Carro(Modelo umModelo, double umDistanciaPorLitro, double limiteGasolina) {
		this.dono = null;
		this.modelo = umModelo;
		this.tanque = new TanqueDeGasolina(0, limiteGasolina);
		this.distanciaPorLitro = umDistanciaPorLitro;
	}

	public Pessoa GetDono() {
		return dono;
	}

	public void SetDono(Pessoa dono) {
		this.dono = dono;
	}

	public TanqueDeGasolina GetTanque() {
		return tanque;
	}

	public Modelo GetModelo() {
		return modelo;
	}

	public double GetDistanciaPorLitro() {
		return distanciaPorLitro;
	}
	
	public double GetLimiteGasolina() {
		return GetTanque().GetLimiteGasolina();
	}
	
	public double GetKilometragem() {
		return this.kilometragem;
	}
	
	public double AddGasolina(double gasolina) {
		return GetTanque().AumentaGasolina(gasolina);
	}
	
	public double Anda(double kilometros) {
		double gasolinaGasta = CalcGastoGasPorDistancia(kilometros);
		gasolinaGasta = GetTanque().GastarGasolina(gasolinaGasta);
		double distanciaAndado = this.distanciaPorLitro*gasolinaGasta;
		kilometragem+=distanciaAndado;
		return distanciaAndado;
	}
	
	private double CalcGastoGasPorDistancia(double kilometro) {
		return kilometro/this.distanciaPorLitro;
	}

	
	public override string ToString() {
		string res = "";
		res += GetType().Name + "\n";
		res += "Dono: " + dono + "\n";
		res += "Modelo: " + modelo + "\n";
		res += "tanque: " + tanque + "\n";
		res += "distancia por litro: " + distanciaPorLitro + "\n";
		res += "kilometragem: " + kilometragem + "\n";
		return res;
	}
	
}
