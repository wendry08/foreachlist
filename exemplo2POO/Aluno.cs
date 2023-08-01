public class Aluno
{
    public String nome { get; set; }
    public int Matricula { get; set; }
    public string CPF { get; set; }
    public DateOnly dataNascimento { get; set; }

    public Aluno()
    {

    }
    public Aluno(string nome,int matricula, string cpf, DateOnly dataNascimento)
    {
        this.Matricula = matricula;
        this.nome = nome;
        this.CPF = cpf;
        this.dataNascimento = dataNascimento;
    }
}
