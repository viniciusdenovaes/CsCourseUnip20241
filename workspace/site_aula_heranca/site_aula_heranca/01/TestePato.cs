class TestePato {
    public static void Main(string[] args) {
        Pato pato = new Pato("joao", 1999);
        Console.WriteLine(pato);
        pato.Voa();
        pato.Nada();


        PatoSubmarino patoSubmarino = new PatoSubmarino("atomico", 2000, 555);
        Console.WriteLine(patoSubmarino);
        patoSubmarino.Voa();
        patoSubmarino.Nada();
    }
}
