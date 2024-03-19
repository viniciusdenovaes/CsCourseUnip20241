namespace ex03;

public class Rendimento {
	
	private Materia materia;
	private Nota notas;
	public Rendimento(Materia materia, Nota notas) {
		this.materia = materia;
		this.notas = notas;
	}
	public Materia GetMateria() {
		return materia;
	}
	public void SetMateria(Materia materia) {
		this.materia = materia;
	}
	public Nota GetNotas() {
		return notas;
	}
	public void SetNota(Nota notas) {
		this.notas = notas;
	}
	
	public bool GetAprovacao() {
		return (notas.GetMediaSemExame()>=7) || (notas.GetMediaComExame()>=5);
	}
	
	
	public override string ToString() {
		return "Rendimento [materia=" + materia + ", nota=" + notas + ", Aprovado=" + GetAprovacao() + "]";
	}
	
	

}
