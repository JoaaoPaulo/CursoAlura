class Funcionario
{
    public string Nome { get; set; }
    private double salario;

    public Funcionario(string nome, decimal salarioInicial)
    {
        Nome = nome;
        salario = salarioInicial;
    }

    public void ReajustarSalario(double novoValor)
    {
        if(novoValor > salario)
        {
            salario = novoValor;
        }
        else
        {
            Console.WriteLine("O novo valor não pode ser menor que o salário atual.")
        }
    }

    public double salario
    {
        get { return salario; }
    }

}