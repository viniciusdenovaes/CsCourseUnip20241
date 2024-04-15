class PatoSubmarino: Pato {
    private double velocidade;
    public PatoSubmarino(string aNome, int aAno, double aVelocidade): base(aNome, aAno){
        this.velocidade = aVelocidade;
    }
    public override void Nada()
    {
        Console.WriteLine("Nada com uma velocidade de " + this.velocidade);
    }

    public override string ToString()
    {
        string res = base.ToString();
        res += "Velocidade: " + this.velocidade + "\n";
        return res;
    }

}

