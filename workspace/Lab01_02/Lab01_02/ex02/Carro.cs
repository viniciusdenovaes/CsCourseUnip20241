namespace ex02;

public class Carro {
	
	private Pessoa dono;
	private int ano;
	
	public Carro(Pessoa aDono, int aAno) {
		this.dono = aDono;
		this.ano = aAno;
	}

	public Pessoa GetDono() {
		return dono;
	}

	public void SetDono(Pessoa dono) {
		this.dono = dono;
	}

	public int GetAno() {
		return ano;
	}

	public override string ToString() {
		string res = "";
		res += this.GetType().Name + "\n";
		res += "Dono: " + dono + "\n";
		res += "Ano: " + ano + "\n";
		return res;
	}
	
	
	
	

}
