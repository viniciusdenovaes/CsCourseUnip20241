class PatoSubmarinoAtomico: PatoSubmarino {
    private double poder;
    public PatoSubmarinoAtomico(string aNome, int aAno, double aVelocidade, double aPoder): base(aNome, aAno, aVelocidade){
        this.poder = aPoder;
    }
    public override void Nada() {
        base.Nada();
        Console.WriteLine($"e {this.poder} de poder");
    }

    public override string ToString()
    {
        string res = base.ToString();
        res += "Poder: " + this.poder + "\n";
        return res;
    }

}

