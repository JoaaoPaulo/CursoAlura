List<Transporte> opcoes = new List<Transporte
{
    new Onibus(),
    new Metro(),
    new Bicicleta()
}

foreach(var o in opcoes)
{
    Console.WriteLine($"{transporte.GetType().Name}: {transporte.CalcularTempo(distancia)} min");
}