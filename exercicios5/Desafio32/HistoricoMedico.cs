internal class HistoricoMedico
{
    public string CodigoPontuario{ get; set; }

    public HistoricoMedico(string codigo)
    {
        CodigoProntuario = codigo;
    }

    public void ExibirCodigo()
    {
        Console.WriteLine("Código do prontuário: " + CodigoProntuario);
    }
}