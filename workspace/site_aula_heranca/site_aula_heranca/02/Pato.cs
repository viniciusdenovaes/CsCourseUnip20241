namespace sem_classe_abstrata;

class Pato {
    private string nome;
    private int idade;

    public Pato(string aNome) {
        this.nome = aNome;
        this.idade = 0;
    }

    public string GetNome() { return this.nome; }
    public int GetIdade() { return this.idade; }

    public void AumentaIdade() { this.idade++; }

    public string FazBarulho() {
        return "Quaaak";
    }

    public override string ToString() {
        string res = "";
        res += "Classe: Pato\n";
        res += "Nome: " + this.nome + "\n";
        res += "Idade: " + this.idade + "\n";
        res += "Barulho: " + this.FazBarulho() + "\n";
        return res;
    }
}
