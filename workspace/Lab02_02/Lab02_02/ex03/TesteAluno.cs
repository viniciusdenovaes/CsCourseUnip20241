namespace ex03;

public class TesteAluno {
	
	static void Main(string[] args) {
		
		Aluno a = new Aluno("123", "Ana");
		
		a.addRendimento(new Rendimento(new Materia("IPE", 2021), new Nota(10, 10, 0)));
		a.addRendimento(new Rendimento(new Materia("BD", 2022), new Nota(5, 4, 5)));
		a.addRendimento(new Rendimento(new Materia("LPOO", 2023), new Nota(6, 6, 0)));
		a.addRendimento(new Rendimento(new Materia("ALPOO", 2023), new Nota(6, 6, 6)));
		
		Console.WriteLine(a);
		
		a.fazRelatorio();
		
	}

}
