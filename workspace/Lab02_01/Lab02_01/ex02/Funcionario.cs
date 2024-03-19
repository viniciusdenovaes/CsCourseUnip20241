namespace ex02;

public class Funcionario {
	
	private string id;
	private string nome;
	private double salario;
	public Funcionario(string aId, string aNome, double aSalario) {
		this.id = aId;
		this.nome = aNome;
		this.salario = aSalario;
	}
	public double GetSalario() {
		return salario;
	}
	public void SetSalario(double salario) {
		this.salario = salario;
	}
	public string GetId() {
		return id;
	}
	public string GetNome() {
		return nome;
	}
	
	public void AumentaSalarioPorcentagem(double umPorcento) {
		double aumento = salario*(umPorcento/100.0);
		salario += aumento;
	}
	
	public void AumentaSalarioAbsoluto(double umValor) {
		salario += umValor;
	}
	
	public override string ToString() {
		return "Funcionario [id=" + id + ", nome=" + nome + ", salario=" + salario + "]";
	}
	

}
