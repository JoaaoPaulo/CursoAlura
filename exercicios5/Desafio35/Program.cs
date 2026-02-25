ContaBancaria conta = new ContaBancaria("Carlos Silva", 2500);
conta.Sacar(1500);
conta.Sacar(800);
Console.WriteLine("Saldo atual: R$ " + conta.Saldo.ToString("F2"));