namespace ex03;

public class Aluno {
	
	public string ra;
	public Cadastro cadastro;
	public double notaNP1;
	public double notaNP2;
	
	public Aluno(string aRa, Cadastro aCadastro, 
			double aNotaNP1, double aNotaNP2) {
		this.ra = aRa;
		this.cadastro = aCadastro;
		this.notaNP1 = aNotaNP1;
		this.notaNP2 = aNotaNP2;
	}
	
	public void Relatorio() {
		Console.WriteLine(this);
		double media = (this.notaNP1 + this.notaNP2)/2.0;
		if(media>=7) {
			Console.WriteLine("O aluno passou");
		}else {
			Console.WriteLine("O aluno nao passou");
		}
		Console.WriteLine();
	}

	
	public override string ToString() {
		string res = "";
		res += this.cadastro + "\n";
		res += "RA: " + this.ra + "\n";
		res += "NotaNP1: " + this.notaNP1 + "\n";
		res += "NotaNP2: " + this.notaNP2;
		return res;
	}
	
	
	
	

}
