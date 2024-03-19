namespace ex02;

public class Pessoa {
	
	private string nome;
	private string sobrenome;
	
	public Pessoa(string aNome, string aSobrenome) {
		this.nome = aNome;
		this.sobrenome = aSobrenome;
	}

	public string GetNome() {
		return nome;
	}

	public string GetSobrenome() {
		return sobrenome;
	}

	public override string ToString() {
		string res = "";
		res += this.GetType().Name + ":\n";
		res += "Nome: " + nome + "\n";
		res += "Sobrenome: " + sobrenome + "\n";
		return res;
	}
	
}
