namespace ex01;

public class Modelo {
	
	private string nome;
	private int ano;
	public Modelo(string nome, int ano) {
		this.nome = nome;
		this.ano = ano;
	}
	public string GetNome() {
		return nome;
	}
	public int GetAno() {
		return ano;
	}
	
	public override string ToString() {
		return "Modelo [nome=" + nome + ", ano=" + ano + "]";
	}
	

}
