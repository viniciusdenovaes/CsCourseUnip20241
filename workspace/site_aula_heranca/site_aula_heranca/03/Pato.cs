namespace classe_abstrata;

class Pato : Animal {

    public Pato(string aNome) : base(aNome){}

    public override string FazBarulho() {
        return "Quaaack";
    }

}
