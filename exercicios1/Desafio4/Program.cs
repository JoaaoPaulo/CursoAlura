Funcionario funcionario = new Funcionario("João Paulo", "Dev");

Console.WriteLine("Funcionário: " + funcionario.Nome);
Console.WriteLine("Cargo Atual: " + funcionario.Cargo);

funcionario.Promover("Dev");
funcionario.Promover("Desenvolvedor");

Console.WriteLine("--- Após promoção ---");
Console.WriteLine("Funcionário: " + funcionario.Nome);
Console.WriteLine("Cargo Atual: " + funcionario.Cargo);