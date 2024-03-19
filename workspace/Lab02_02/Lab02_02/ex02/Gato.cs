namespace ex02;

public class Gato {
	private string nome;
	private int idade;
	private double peso;
	private bool isDoente;
	
	public Gato(string nome, int idade, double peso) {
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
	
	public void Miar() {
		Console.WriteLine("miaaauu");
	}
	
	public void Dormir() {
		Console.WriteLine("foi dormir no alto");
	}
	
	public void Comer() {
		Console.WriteLine("comendo racao de gato");
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
