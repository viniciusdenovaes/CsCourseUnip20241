class TestePolimorfismo {
    public static void Main(string[] args) {
        Pato pato01 = new Pato("joao", 1999);
        Console.WriteLine(pato01);
        pato01.Voa();
        pato01.Nada();


        Pato patoSubmarino = new PatoSubmarino("atomico", 2000, 555);
        Console.WriteLine(patoSubmarino);
        patoSubmarino.Voa();
        patoSubmarino.Nada();


        Console.WriteLine();
        Console.WriteLine("\n----------------------------------------");
        Console.WriteLine("Fazendo uma lista de patos do tipo Pato");
        Console.WriteLine("----------------------------------------\n");
        List<Pato> patos = new List<Pato>();
        patos.Add(pato01);
        patos.Add(patoSubmarino);

        foreach (Pato pato in patos) {
            Console.WriteLine(pato);
            pato.Voa();
            pato.Nada();
        }

    }
}
