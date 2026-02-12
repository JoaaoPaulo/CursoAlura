public class Consulta
{
    public string NomePaciente { get; set; }
    public string NomeMedico { get; set; }
    public DateTime DataConsulta { get; set; }
    private bool foiReagendada;

    public Consulta(string paciente, string medico, DateTime data)
    {
        NomePaciente = paciente;
        NomeMedico = medico;
        DataConsulta = data;
        foiReagendada = false;
    }

    public void Reagendar(DateTime novaData)
    {
        DataConsulta = novaData;
        foiReagendada = true;
    }

    public void ExibirResumo()
    {
        Console.WriteLine($"Consulta marcada com {NomeMedico} para o paciente {NomePaciente}");
        if(foiReagendada)
        {
            Console.WriteLine("Nova data da consulta: " + DataConsulta.ToString("dd/MM/yyyy"));
        }
        else
        {
            Console.WriteLine("Data da consulta: " + DataConsulta.ToString("dd/MM/yyyy"));
        }
    }
}