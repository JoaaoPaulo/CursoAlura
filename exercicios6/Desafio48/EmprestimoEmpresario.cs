public class EmprestimoEmpresario: IEmprestimo
{
    public decimal CalcularValorFinal(decimal valor, int meses)
    {
        return valor + (valor * 1,025 * meses);
    }
}