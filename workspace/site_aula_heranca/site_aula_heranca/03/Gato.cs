namespace classe_abstrata;

class Gato : Animal {

    public Gato(string aNome) : base(aNome){}

    public override string FazBarulho() {
        return "Miau";
    }

}
