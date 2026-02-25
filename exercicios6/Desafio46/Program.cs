List<Conteudo> conteudos = new List<Conteudo>
{
    new AulaGravada("POO na prática", 45),
    new MaterialComplementar("Resumo do módulo 2", 12)
};

foreach (var conteudo in conteudos)
{
    ExibirInfo();
}