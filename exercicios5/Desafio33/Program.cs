Funcionario f = new Funcionario("Fernanda Lima", 4000);
f.ReajustarSalario(3500);
f.ReajustarSalario(4200);

Console.WriteLine("Funcionário: " + f.Nome);
Console.WriteLine("Salário atual: R$ " + f.Salario.ToString("F2"));