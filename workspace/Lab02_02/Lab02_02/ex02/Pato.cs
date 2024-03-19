namespace ex02;

public class Pato {
	private string nome;
	private int idade;
	private double peso;
	private bool isDoente;
	
	public Pato(string nome, int idade, double peso) {
		this.nome = nome;
		this.idade = idade;
		this.peso = peso;
		this.isDoente = false;
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

	public bool GetIsDoente() {
		return isDoente;
	}
	
	public void AumentaIdade() {
		idade++;
	}
	
	public void Quack() {
		Console.WriteLine("quaaack quaack");
	}
	
	public void Dormir() {
		Console.WriteLine("foi dormir no quintal");
	}
	
	public void Comer() {
		Console.WriteLine("comendo o que o pato come");
	}
	
	public void DarInjecao() {
		isDoente = false;
	}
	
	public void Adoecer() {
		isDoente = true;
	}

	
	public override string ToString() {
		return GetType().Name + "[nome=" + nome + ", idade=" + idade + ", peso=" + peso + ", isDoente=" + isDoente + "]";
	}
	
	
	
}
