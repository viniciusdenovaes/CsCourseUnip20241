namespace sem_classe_abstrata;

class Cachorro {
    private string nome;
    private int idade;

    public Cachorro(string aNome) {
        this.nome = aNome;
        this.idade = 0;
    }

    public string GetNome() { return this.nome; }
    public int GetIdade() { return this.idade; }

    public void AumentaIdade() { this.idade++; }

    public string FazBarulho() {
        return "au au";
    }

    public override string ToString() {
        string res = "";
        res += "Classe: Cachorro\n";
        res += "Nome: " + this.nome + "\n";
        res += "Idade: " + this.idade + "\n";
        res += "Barulho: " + this.FazBarulho() + "\n";
        return res;
    }
}
