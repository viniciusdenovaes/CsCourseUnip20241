namespace ex02;

public class TesteFuncionario {
	
	static void Main(string[] args) {
		
		Funcionario f01 = new Funcionario("123", "Ana", 2000);
		Console.WriteLine(f01);
		
		f01.AumentaSalarioPorcentagem(10);
		Console.WriteLine(f01);
		
		f01.AumentaSalarioAbsoluto(10);
		Console.WriteLine(f01);
		
	}

}
