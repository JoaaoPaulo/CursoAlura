Avaliacao avaliacao = new Avaliacao("Joao");

avaliacao.AtribuirNota(11);
avaliacao.AtribuirNota(8.5);

Console.WriteLine("Aluno: " + avaliacao.Aluno);
Console.WriteLine("Nota atribuída: " + avaliacao.Nota);