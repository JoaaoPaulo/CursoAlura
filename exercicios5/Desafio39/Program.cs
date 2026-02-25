Hospede hospede = new Hospede("Juliana Moura");
Quarto quarto = new Quarto(101);
quarto.ValorDiaria = 250;

Reserva reserva = new Reserva(hospede, quarto, 3);

Console.WriteLine("Reserva para: " + reserva.Hospede.Nome);
Console.WriteLine("Quarto: " + reserva.Quarto.Numero);
Console.WriteLine("Valor total: R$ " + reserva.ValorTotal.ToString("F2"));