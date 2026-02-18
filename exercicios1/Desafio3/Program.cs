ContaBancaria conta = new ContaBancaria("7891-3", 1000.00);
conta.Depositar(500.00);

Console.WriteLine($"Número da conta: {conta.NumeroConta} - valor {conta.Saldo.ToString("F2")}");