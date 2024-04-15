namespace classe_abstrata;

class Cachorro : Animal {

    public Cachorro(string aNome) : base(aNome){}

    public override string FazBarulho() {
    return "au au";
}
}
