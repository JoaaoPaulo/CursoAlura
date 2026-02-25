List<TarefaAgenda> tarefas = new List<TarefaAgenda>
{
    new BackupTarefa(),
    new RelatorioTarefa(),
    new LimpezaTarefa()
};

foreach (var tarefa in tarefas)
{
    tarefa.Executar();
}