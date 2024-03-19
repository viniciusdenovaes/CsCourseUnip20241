namespace ex02;

public class TesteAluno {
	
	static void Main(string[] args) {
		Aluno aluno01 = new Aluno("123", new Nome("fulano", "Silva"), 7.0, 8.5);
		aluno01.Relatorio();
		
		Aluno aluno02 = new Aluno("124", new Nome("beltrano", "Souza"), 4.0, 7.5);
		aluno02.Relatorio();
	}

}
