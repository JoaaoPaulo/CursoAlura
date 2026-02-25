class Curso
{
    public string Nome { get; set; }
    public int VagasTotais { get; set; }
    private List<Estudante> matriculas;

    public Curso(string nome, int vagasTotais)
    {
        Nome = nome;
        VagasTotais = vagasTotais;
        matriculas = new List<Estudante>();
    }

    public bool Matricular(Estudante estudante)
    {
        if (matriculas.Count <= VagasTotais)
        {
            matriculas.Add(estudante);
            Console.WriteLine("Aluno matriculado com sucesso!");
            return true;
        }
        else
        {
            Console.WriteLine("Este curso não possui mais vagas.");
            return false;
        }
    }

    public void ListarMatriculados()
    {
        Console.WriteLine($"Estudantes cadastrados em {Nome}: ")
        foreach (var estudante in matriculas)
        {
            Console.WriteLine($"{estudante.Nome}");
        }
    }

    public int VagasDisponiveis()
    {
        get { return VagasTotais - matriculas.Count; }
    }
}