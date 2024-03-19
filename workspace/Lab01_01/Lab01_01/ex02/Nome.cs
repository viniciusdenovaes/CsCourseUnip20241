namespace ex02;

public class Nome {
	
	string primeiroNome;
	string sobreNome;
	
	public Nome(string aPrimeiroNome, string aSobrenome) {
		this.primeiroNome = aPrimeiroNome;
		this.sobreNome = aSobrenome;
	}
	
	
	public override string ToString() {
		string res = "";
		res += this.primeiroNome + " " + this.sobreNome;
		return res;
	}
	

}
