class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }

    public Funcionario(string nome, string cargo)
    {
        Nome = nome;
        Cargo = cargo;
    }

    public void Promover(string novoCargo)
    {
        if (novoCargo != Cargo)
        { 
            Cargo = novoCargo;
        }
        else
        {
            Console.WriteLine("O novo cargo não pode ser o mesmo do anterior");
        }
    }
}