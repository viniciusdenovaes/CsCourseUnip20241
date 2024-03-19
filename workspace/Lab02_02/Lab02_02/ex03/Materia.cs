namespace ex03;

public class Materia {
	
	private string nome;
	private int ano;
	public Materia(string nome, int ano) {
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
		return "Materia [nome=" + nome + ", ano=" + ano + "]";
	}
	

}
