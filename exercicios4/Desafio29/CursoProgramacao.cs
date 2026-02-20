class CursoProgramacao : ICurso
{
    private string Titulo;
    private Instrutor Instrutor;

    public CursoProgramacao(string titulo, Instrutor instrutor)
    {
        Titulo = titulo;
        Instrutor = instrutor;
    }

    public void ValidarConteudo()
    {
        Console.WriteLine($"Validando conteúdo do curso de programação: {Titulo}");
    }
 
    public void PublicarCurso()
    {
        Console.WriteLine($"Curso publicado com sucesso: {Titulo} - Instrutora: {Instrutor.Nome} ({Instrutor.Especialidade})\n");
    }
}