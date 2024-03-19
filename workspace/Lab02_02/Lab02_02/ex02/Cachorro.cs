namespace ex02;

public class Cachorro {
	private string nome;
	private int idade;
	private double peso;
	private bool isDoente;
	
	public Cachorro(string nome, int idade, double peso) {
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
	
	public void Latir() {
		if(peso<4) {
			Console.WriteLine("au au au");
		}
		else if(peso>=4 && idade<=10) {
			Console.WriteLine("AU AU AU");
		}else {
			Console.WriteLine("ROOF ROOF ROFF");
		}
	}
	
	public void Dormir() {
		Console.WriteLine("foi dormir no sofa");
	}
	
	public void Comer() {
		Console.WriteLine("comendo racao de cachorro");
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
