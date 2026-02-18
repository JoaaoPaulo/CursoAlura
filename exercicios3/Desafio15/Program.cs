public interface Iforma
{
    double CalcularArea();
    double CalcularPerimetro();
}

public class Circulo : Iforma
{
    public double Raio { get; set; }

    public double CalcularArea()
    {
        return Math.PI  * Math.Pow(Raio, 2);
    }
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * Raio;
    }
}

public class Retangulo : Iforma
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public double CalcularArea()
    {
        return Largura * Altura;
    }
    public double CalcularPerimetro()
    {
        return 2 * (Largura * Altura);
    }
}