namespace sem_classe_abstrata;

class TesteSemClasseAbstrata {
    static public void Main(string[] args) {
        Cachorro cachorro = new Cachorro("Brutus");
        Gato gato = new Gato("Chirriro");
        Pato pato = new Pato("Donaldo");

        Console.WriteLine(cachorro);
        Console.WriteLine(gato);
        Console.WriteLine(pato);

        cachorro.AumentaIdade();
        gato.AumentaIdade();
        pato.AumentaIdade();

        Console.WriteLine(cachorro);
        Console.WriteLine(gato);
        Console.WriteLine(pato);
    }
}
