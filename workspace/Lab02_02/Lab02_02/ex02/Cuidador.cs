namespace ex02;

public class Cuidador {
	
	private string nome;
	private List<Cachorro> cachorros;
	private List<Gato> gatos;
	private List<Pato> patos;
	
	public Cuidador(string nome) {
		this.nome = nome;
		this.cachorros = new List<Cachorro>();
		this.gatos = new List<Gato>();
		this.patos = new List<Pato>();
	}

	public string GetNome() {
		return nome;
	}

	public List<Cachorro> GetCachorros() {
		return cachorros;
	}

	public List<Gato> GetGatos() {
		return gatos;
	}

	public List<Pato> GetPatos() {
		return patos;
	}
	
	public void AddCachorro(Cachorro cachorro) {
		cachorros.Add(cachorro);
	}
	public void AddGato(Gato gato) {
		gatos.Add(gato);
	}
	public void AddPato(Pato pato) {
		patos.Add(pato);
	}

	
	public override string ToString() {
		string res = "";
		res += "\nCuidador [nome=" + nome + "\n";
        res += "cachorros=[\n";
        foreach (Cachorro c in cachorros)
        {
            res += "\t" + c + ", \n";
        }
        res += "]\n";
        res += "gatos=[\n";
        foreach (Gato g in gatos)
        {
            res += "\t" + g + ", \n";
        }
        res += "]\n";
        res += "patos=[\n";
        foreach (Pato p in patos)
        {
            res += "\t" + p + ", \n";
        }
        res += "]\n";
		return res;
	}
	
	
	
	

	
	
	
	
	
	
}
