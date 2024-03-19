namespace ex01;

public class TesteCachorro {
	
	static void Main(string[] args) {
		
		Cachorro c01 = new Cachorro("Brutus", 22);
		
		Console.WriteLine(c01);
		
		for(int i=0; i<3; i++) {
			Console.WriteLine("Aumentando a idade do cachorro pelo " + (i+1) + "esima vez");
			c01.AumentaIdade();
			Console.WriteLine(c01);
		}
		
		
	}

}
