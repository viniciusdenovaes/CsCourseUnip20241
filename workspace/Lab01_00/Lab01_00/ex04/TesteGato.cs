namespace ex04;

public class TesteGato {
	
	static void Main(string[] args) {
		
		Gato gato01 = new Gato("Brutus", 5.5);
        gato01.idade = 2;
        Console.WriteLine(gato01);
        
        Gato gato02 = new Gato("ligeirinho", 7.5);
        gato02.idade = 4;
        Console.WriteLine(gato02);
        
        Gato gato03 = new Gato("alfredo", 9.5);
        gato03.idade = 9;
        Console.WriteLine(gato03);
	}
	
}
