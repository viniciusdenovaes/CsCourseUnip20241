class Pato{
    private string nome;
    private int ano;
    public Pato(string aNome, int aAno){
        this.nome = aNome;
        this.ano = aAno;
    }

    public string GetNome(){
        return nome;
    }
    public int GetAno(){
        return ano;
    }
    public virtual void Voa(){
        Console.WriteLine("O Pato voa");
    }
    public virtual void Nada(){
        Console.WriteLine("O Pato nada");
    }
    public override string ToString(){
        string res = "classe " + this.GetType().Name + "\n";
        res += "nome: " + this.nome + "\n";
        res += "nascimento: " + this.ano + "\n";
        return res;
    }
}
