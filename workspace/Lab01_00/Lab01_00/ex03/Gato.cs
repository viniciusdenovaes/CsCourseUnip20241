namespace ex03;

public class Gato {
	
	public String nome;
	public int idade;
	public double peso;
	
	public Gato(String aNome, double aPeso) {
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

}
