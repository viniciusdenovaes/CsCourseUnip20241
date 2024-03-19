namespace ex04;

public class Boletim {
	
	double notaNP1;
	double notaNP2;
	
	public Boletim(double aNotaNP1, double aNotaNP2) {
		this.notaNP1 = aNotaNP1;
		this.notaNP2 = aNotaNP2;
	}
	
	public double Media() {
		return (this.notaNP1 + this.notaNP2)/2.0;
	}
	
	public bool Passou() {
		if(this.Media()<7) {
			return false;
		}
		return true;
	}
	
	
	public override string ToString() {
		string res = "Boletim: \n";
		res += "NotaNP1: " + this.notaNP1 + "\n";
		res += "NotaNP2: " + this.notaNP2;
		
		return res;
	}
	
	

}
