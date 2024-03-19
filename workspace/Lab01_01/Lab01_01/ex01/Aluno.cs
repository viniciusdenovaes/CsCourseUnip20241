namespace ex01;

public class Aluno {
	
	public string ra;
	public string nome;
	public double notaNP1;
	public double notaNP2;
	
	public Aluno(string aRa, string aNome, 
			double aNotaNP1, double aNotaNP2) {
		this.ra = aRa;
		this.nome = aNome;
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
		res += "Nome: " + this.nome + "\n";
		res += "RA: " + this.ra + "\n";
		res += "NotaNP1: " + this.notaNP1 + "\n";
		res += "NotaNP2: " + this.notaNP2;
		return res;
	}
	
	
	
	

}
