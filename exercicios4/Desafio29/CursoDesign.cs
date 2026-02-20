class CursoDesign : ICurso
{
    private string Titulo;
    private Instrutor Instrutor;

    public CursoDesign(string titulo, Instrutor instrutor)
    {
        Titulo = titulo;
        Instrutor = instrutor
    }

    public void ValidarConteudo()
    {
        Console.WriteLine($"Validando conteúdo do curso de design: {Titulo}");
    }
 
    public void PublicarCurso()
    {
        Console.WriteLine($"Curso publicado com sucesso: {Titulo} - Instrutor: {Instrutor.Nome} ({Instrutor.Especialidade})\n");
    }
}