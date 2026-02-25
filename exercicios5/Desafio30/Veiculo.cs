class Veiculo 
{
    public string Placa { get; set; }
    private double velocidadeAtual;

    public Veiculo(string placa)
    {
        Placa = placa;
    }

    public void AtualizarVelocidade(double novaVelocidade)
    {
        velocidadeAtual = novaVelocidade;
    }

    public double velocidadeAtual
    {
        get { return velocidadeAtual;  }
    }
}