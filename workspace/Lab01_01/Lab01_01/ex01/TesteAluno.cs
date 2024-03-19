namespace ex01;

public class TesteAluno {
	
	static void Main(string[] args) {
		Aluno aluno01 = new Aluno("123", "fulano", 7.0, 8.5);
		aluno01.Relatorio();
		
		Aluno aluno02 = new Aluno("124", "beltrano", 4.0, 7.5);
		aluno02.Relatorio();
	}

}
