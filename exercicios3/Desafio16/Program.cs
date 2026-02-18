public interface IPitolavel
{
    void Pilotar();
}
public interface IVoavel
{
    void Voar();
}

public class Veiculo : IPitolavel, IVoavel
{
    public void Pilotar()
    {
        Console.WriteLine("Veículo está pilotando");
    }

    public void Voar()
    {
        Console.WriteLine("Veículo está voando");
    }
}