class Gato {
    private String nome;
    public Gato(String aNome) {
        this.nome = aNome;
    }
    public override string ToString() {
        String res = "";
        res += "Gato de Nome " + this.nome + "\n";
        return res;
    }
    public static void Main(String[] args) {
        List<Gato> gatos = new List<Gato>();

        Gato gato01 = new Gato("Brutos");
        gatos.Add(gato01);

        Gato gato02 = new Gato("Chitara");
        gatos.Add(gato01);

        gatos.Add(new Gato("Chirriro"));

        Console.WriteLine("Primeiro: for");
        for (int i = 0; i < gatos.Count; i++) {
            Console.WriteLine(gatos[i]);
        }

        gatos[1] = new Gato("Segundos");

        Console.WriteLine("Segundo: for-each");
        foreach (Gato gato in gatos) {
            Console.WriteLine(gato);
        }

        Console.WriteLine("Outra lista de gatos");
        List<Gato> outrosGatos = new List<Gato>(gatos);
        foreach (Gato gato in outrosGatos) {
            Console.WriteLine(gato);
        }
    }
}
