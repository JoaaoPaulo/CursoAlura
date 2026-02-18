public class Produto
{
    public string Nome { get; set; }
    private int quantidadeEstoque;

    public Produto(string nome, int quantidadeInicial)
    {
        Nome = nome;
        quantidadeEstoque = quantidadeInicial;
    }

    public void Retirar(int quantidade)
    {
        if(quantidade <= quantidadeEstoque)
        {
            quantidadeEstoque -= quantidade;
        }
        else
        {
            Console.WriteLine("Não há estoque disponível.");
        }
    }

    public void ExibirEstoque()
    {
        Console.WriteLine("Produto: " + Nome);
        Console.WriteLine("Estoque atual: " + quantidadeEstoque);
    }
}