class Projeto
{
    public string Nome { get; set;}
    private List<string> tarefas;

    public Projeto(string nome)
    {
        Nome = nome;
        tafefas = new List<string>();
    }

    public void AdicionarTarefa(string tarefa)
    {
        tafefas.Add(tarefa);
    }

    public void ExibirTarefas()
    {
        Console.WriteLine("Projeto: " + Projeto);
        Console.WriteLine("Tarefas:");
        foreach(string tarefa in tarefas)
        {
            Console.WriteLine("- Tarefa: " + tarefa);
        }
    }

    public int QuantidadeTarefas()
    {
        get { return tarefas.Count; }
    }
}