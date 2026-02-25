public class Onibus : Transporte
{
    public override int CalcularTempo(distanciaKm)
    {
        get { return (distanciaKm * 2) + 5; }
    }
}