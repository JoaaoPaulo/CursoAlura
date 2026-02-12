public class Pedido
{
    public string NumeroPedido { get; set; }
    public string NomeCliente { get; set; }
    public string Status { get; set; }

    public Pedido(string numeroPedido, string nomeCliente, string status)
    {
        NumeroPedido = numeroPedido;
        NomeCliente = nomeCliente;
        Status = status;
    }

    public void AtualizarStatus(string novoStatus)
    {
        Status = novoStatus;
    }
    public void ExibirPedido()
    {
        Console.WriteLine("Número do pedido: " + NumeroPedido);
        Console.WriteLine("Nome do cliente: " + NomeCliente);
        Console.WriteLine("Status do pedido: " + Status);
    }
}