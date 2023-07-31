public class Aluno
{
    public int Matricula { get; set; }
    public String nome { get; set; }
    public string CPF { get; set; }
    public DateOnly dataNascimento { get; set; }

    public Aluno()
    {

    }
    public Aluno(int matricula, string nome, string cpf, DateOnly dataNascimento)
    {
        this.Matricula = matricula;
        this.nome = nome;
        this.CPF = cpf;
        this.dataNascimento = dataNascimento;
    }
}
