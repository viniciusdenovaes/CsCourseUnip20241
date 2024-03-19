namespace ex03;

public class TesteGato {
	
	static void Main(String[] args) {
		
		Gato gato01 = new Gato("Brutus", 5.5);
        gato01.idade = 2;
        gato01.Miar();
        
        Gato gato02 = new Gato("ligeirinho", 7.5);
        gato02.idade = 4;
        gato02.Miar();
        
        Gato gato03 = new Gato("alfredo", 9.5);
        gato03.idade = 9;
        gato03.Miar();
	}
	
}
