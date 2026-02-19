class Passageiro : Pessoa
{
    public int QuantidadeBilhetes { get; }

    public Passageiro(string nome, int idade, int quantidadeBilhetes) : Base(nome, idade)
    {
        this.QuantidadeBilhetes = quantidadeBilhetes;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Passageiro: {this.Nome} - Idade: {this.Idade} - Bilhetes: {this.QuantidadeBilhetes}")
    }
}