class ContaBancaria
{
    public string Titular { get; set; }
    private double saldo;

    public ContaBancaria(string titular, decimal saldoInicial)
    {
        Titular = titular;
        saldo = saldoInicial;
    }

    public void Sacar(double valor)
    {
        SegurancaConta seguranca = new SegurancaConta();
        if (seguranca.ValidarSaque(valor))
        {
            saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso.");
        }
        else
        {
            Console.WriteLine("Saque negado pela política de segurança.");
        }
    }

    public double Saldo()
    {
        return saldo;
    }
}