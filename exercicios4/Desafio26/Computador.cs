class Computador
{
    private Processador Cpu;
    private PlacaMae Mobo;

    Public Computador(Processador cpu, Processador mobo)
    {
        Cpu = cpu;
        Mobo = mobo;
    }

    public void ExibirConfiguracao()
    {
        Console.WriteLine("Computador configurado com:");
        Console.WriteLine($"Processador: {Cpu.Marca} - {Cpu.Modelo}");
        Console.WriteLine($"Placa-mãe: {Mobo.Fabricante} - {Mobo.Socket}");
    }
}