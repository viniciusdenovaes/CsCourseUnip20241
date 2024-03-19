namespace ex01;

public class Cachorro {
	
	private string nome;
	private int idade;
	private double peso;
	
	public Cachorro(string aNome, double aPeso) {
		this.nome = aNome;
		this.idade = 0;
		this.peso = aPeso;
	}

	public double GetPeso() {
		return peso;
	}

	public void SetPeso(double peso) {
		this.peso = peso;
	}

	public string GetNome() {
		return nome;
	}

	public int GetIdade() {
		return idade;
	}
	
	public void AumentaIdade() {
		idade++;
	}

	public override string ToString() {
		string res = "";
		res += GetType().Name + "\n";
		res += "Nome: " + nome + "\n";
		res += "Idade: " + idade + "\n";
		return res;
	}
	
	
	
	

}
