namespace ex04;

public class Aluno {
	
	public string ra;
	public Cadastro cadastro;
	public Boletim boletim;
	
	public Aluno(string aRa, Cadastro aCadastro, 
			Boletim aBoletim) {
		this.ra = aRa;
		this.cadastro = aCadastro;
		this.boletim = aBoletim;
	}
	
	public void Relatorio() {
		Console.WriteLine(this);
		if(this.boletim.Passou()) {
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
		res += this.boletim;
		return res;
	}
	
	
	
	

}
