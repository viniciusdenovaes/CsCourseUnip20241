namespace ex04;

public class Endereco {
	
	public string rua;
	public int numero;
	
	public Endereco(string aRua, int aNumero) {
		this.rua = aRua;
		this.numero = aNumero;
	}

	
	public override string ToString() {
		return rua + ", " + numero;
	}
	
	
	

}
