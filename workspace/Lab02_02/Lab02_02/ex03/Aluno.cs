namespace ex03;

public class Aluno {
	
	private string id;
	private string nome;
	private List<Rendimento> historico;
	public Aluno(string id, string nome) {
		this.id = id;
		this.nome = nome;
		this.historico = new List<Rendimento>();
	}
	public string GetId() {
		return id;
	}
	public string GetNome() {
		return nome;
	}
	public List<Rendimento> GetHistorico() {
		return historico;
	}
	public void addRendimento(Rendimento rendimento) {
		this.historico.Add(rendimento);
	}
	
	public void fazRelatorio() {
		Console.WriteLine(this);
	}
	
	
	public override string ToString() {
		string res = "";
		res += GetType().Name + "\n";
		res += "Id: " + id + "\n";
		res += "Nome: " + nome + "\n";
		res += "Historico: \n";
		foreach(Rendimento r in historico) {
			res += r + "\n";
		}
		res += "\n";
		return res;
	}
	
	

}
