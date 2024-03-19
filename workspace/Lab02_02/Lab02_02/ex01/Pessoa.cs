namespace ex01;

public class Pessoa {
	
	private string nome;
	private string sobrenome;
	public Pessoa(string nome, string sobrenome) {
		this.nome = nome;
		this.sobrenome = sobrenome;
	}
	public string GetNome() {
		return nome;
	}
	public string GetSobrenome() {
		return sobrenome;
	}
	
	public override string ToString() {
		return "Pessoa [nome=" + nome + ", sobrenome=" + sobrenome + "]";
	}
	

}
