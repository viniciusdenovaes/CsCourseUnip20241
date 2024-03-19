namespace ex04;

public class Gato {
	
	public string nome;
	public int idade;
	public double peso;
	
	public Gato(string aNome, double aPeso) {
		this.nome = aNome;
		this.idade = 0;
		this.peso = aPeso;
	}
	
	public void Miar() {
		
		if(this.idade<3) {
			Console.WriteLine("miau miau miau, meu nome é " + this.nome + ", eu tenho " + this.peso + " quilos");
		}else if(this.idade<=8) {
			Console.WriteLine("miaaau, meu nome é " + this.nome + ", eu tenho " + this.peso + " quilos");
		}else {
			Console.WriteLine("Grrr, meu nome é " + this.nome + ", eu tenho " + this.peso + " quilos");
		}
		
	}
	
	public override string ToString(){
		String res = "";
		res += "Objeto Gato\n";
		res += "Nome: " + this.nome + "\n";
		res += "Idade: " + this.idade + "\n";
		res += "Peso: " + this.peso + "\n";
		return res;
	}
}
