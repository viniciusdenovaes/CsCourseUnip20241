namespace ex03;

public class Nota {
	
	private double np1;
	private double np2;
	private double exame;
	
	public Nota(double np1, double np2, double exame) {
		this.np1 = np1;
		this.np2 = np2;
		this.exame = exame;
	}

	public double GetNp1() {return np1;}
	public double GetNp2() {return np2;}
	public double GetExame() {return exame;}
	public void SetNp1(double np1) {this.np1 = np1;}
	public void SetNp2(double np2) {this.np2 = np2;}
	public void SetExame(double exame) {this.exame = exame;}

	public double GetMediaSemExame() {
		return (np1+np2)/2;
	}
	public double GetMediaComExame() {
		return (GetMediaSemExame()+exame)/2;
	}

	
	public override string ToString() {
		return "Nota [np1=" + np1 + ", np2=" + np2 + ", exame=" + exame + "]";
	}
	
}
