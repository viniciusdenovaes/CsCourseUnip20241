namespace classe_abstrata;

abstract class Animal {
    private string nome;
    private int idade;

    public Animal(string aNome) {
        this.nome = aNome;
        this.idade = 0;
    }

    public string GetNome() { return this.nome; }
    public int GetIdade() { return this.idade; }

    public virtual void AumentaIdade() { this.idade++; }

    abstract public string FazBarulho();

    public override string ToString() {
        string res = "";
        res += "Classe: " + this.GetType().Name + "\n";
        res += "Nome: " + this.nome + "\n";
        res += "Idade: " + this.idade + "\n";
        res += "Barulho: " + this.FazBarulho() + "\n";
        return res;
    }
}
