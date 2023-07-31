Aluno aluno1 = new Aluno();
aluno1.nome = "Elias";
aluno1.CPF = "222";

Aluno aluno2 = new Aluno(11, "Elias", "06578932267", new DateOnly(2006, 04, 05));

List<Aluno> alunos = new List<Aluno>();
alunos.Add(aluno1);
alunos.Add(aluno2);

foreach(Aluno a in alunos)
{
    Console.WriteLine("o nome é " + a.nome + " e o cpf é " + a.CPF);
}
