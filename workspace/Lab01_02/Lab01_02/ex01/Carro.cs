namespace ex01;

public class Carro {
	
	private string modelo;
	private int ano;
	private double tanque;
	
	public Carro(string aModelo, int aAno, double aTanque) {
		this.modelo = aModelo;
		this.ano = aAno;
		this.tanque = aTanque;
	}

	public string GetModelo() {
		return modelo;
	}

	public void SetModelo(string modelo) {
		this.modelo = modelo;
	}

	public int GetAno() {
		return ano;
	}

	public void SetAno(int ano) {
		this.ano = ano;
	}

	public double GetTanque() {
		return tanque;
	}

	public void SetTanque(double tanque) {
		this.tanque = tanque;
	}

	public override string ToString() {
		string res = "";
		res += "Carro: \n";
		res += "Modelo: " + modelo + "\n";
		res += "Ano: " + ano + "\n";
		res += "Tanque: " + tanque+ "\n";
		return res;
	}
	
	
	
	

}
