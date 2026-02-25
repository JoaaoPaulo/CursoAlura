public class EmprestimoEstudante: IEmprestimo
{
    public decimal CalcularValorFinal(decimal valor, int meses)
    {
        return valor + (valor * 1,01 * meses);
    }
}