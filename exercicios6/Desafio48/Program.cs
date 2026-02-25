List<IEmprestimo> perfis = new List<IEmprestimo>
{
    new EmprestimoEstudante(),
    new EmprestimoEmpresario(),
    new EmprestimoAposentado()
};

foreach (var perfil in perfis)
{
    decimal total = perfil.CalcularValorFinal(1000m, 12);
    Console.WriteLine($"{perfil.GetType().Name}: R${total:0.00}");
}