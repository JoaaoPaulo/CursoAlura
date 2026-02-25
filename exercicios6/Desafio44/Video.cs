public class Video : Midia
{
    public int Duracao { get; set;}

    public Imagem(string nome, int duracao) : base(nome)
    {
        Duracao = duracao;
    }

     public override void ExibirDetalhes()
    {
        Console.WriteLine($"Mídia: {Nome} - Duração: {Duracao}")
    }
}