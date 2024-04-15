namespace classe_abstrata;

class TesteComClasseAbstrata {
    static public void Main(string[] args) {

        List<Animal> animais = new List<Animal>();

        animais.Add(new Cachorro("Brutus"));
        animais.Add(new Gato("Chirriro"));
        animais.Add(new Pato("Donaldo"));

        foreach (Animal a in animais) {
            Console.WriteLine(a);
        }

        foreach (Animal a in animais) {
            a.AumentaIdade();
        }

        foreach (Animal a in animais) {
            Console.WriteLine(a);
        }

    }
}
