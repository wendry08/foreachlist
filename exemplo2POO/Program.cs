List<Aluno> alunos = new List<Aluno>();
while (true)
{
    Aluno a = new Aluno();
    Console.Write("Digite o nome do aluno: ");
    a.nome = Console.ReadLine();

    Console.Write("Digite a matrícula do aluno: ");
    a.Matricula = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o CPF do aluno: ");
    a.CPF = Console.ReadLine();

    Console.Write("Digite a data de nascimento do aluno");
    a.dataNascimento = DateOnly.Parse(Console.ReadLine());
    alunos.Add(a);

    Console.WriteLine("quer cadastrar outro aluno");
    Console.WriteLine("0 - sim");
    Console.WriteLine("1 - não");
    Console.WriteLine("digite a acao escolhida");

    int opcaoescolhida = Convert.ToInt32(Console.ReadLine());

    if (opcaoescolhida == 0)
    {

    }
    else if (opcaoescolhida == 2)
    {
        break;
    }
    foreach (Aluno aluno in alunos)
    {
        Console.WriteLine($"O nome é: {a.nome} o cpf é {a.CPF}");
    }
}