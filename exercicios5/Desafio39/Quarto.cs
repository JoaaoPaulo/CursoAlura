class Quarto
{
    public int Numero { get; set; }
    public double ValorDiaria { get; set; }

    public Quarto(int numero)
    {
        Numero = numero;
    }

    private double ValorDiaria;
    public double ValorDiaria
    {
        get { return valorDiaria; }
        set
        {
            if (value > 0)
                valorDiaria = value;
            else
                Console.WriteLine("Erro: O valor da diária deve ser maior que zero.");
        }
    }
}