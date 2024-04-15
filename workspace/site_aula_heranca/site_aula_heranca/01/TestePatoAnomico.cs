class TestePatoAtomico {
    public static void Main(string[] args) {
        Pato pato = new PatoSubmarinoAtomico("joao", 1999, 20, 10);
        Console.WriteLine(pato);
        pato.Voa();
        pato.Nada();

    }
}
