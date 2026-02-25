public class EmprestimoEAposentado: IEmprestimo
{
    public decimal CalcularValorFinal(decimal valor, int meses)
    {
        return valor + (valor * 1,015 * meses);
    }
}