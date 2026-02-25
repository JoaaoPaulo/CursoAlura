List<Reserva> reservas = new List<Reserva>
{
    new ReservaPresencial("Trilha na Serra"),
    new ReservaOnline("Workshop de Culinária Italiana")
};

foreach (var reserva in reservas)
{
    reserva.Confirmar();
}