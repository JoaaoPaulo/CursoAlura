class ClienteVIP : Pessoa
{
    public string Fidelidade { get; }
    public string Codigo { get; }

    public ClienteVIP(string nome, int idade, string fidelidade, string codigo)
        : base(nome, idade)
    {
        this.Fidelidade = fidelidade;
        this.Codigo = codigo;
    }
}
