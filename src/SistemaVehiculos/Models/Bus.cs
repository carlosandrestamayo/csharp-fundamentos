// =========================================
//   CLASE HIJA 3: Bus
// =========================================
class Bus : Vehiculo
{
    private int capacidadPasajeros;

    public int CapacidadPasajeros
    {
        get { return capacidadPasajeros; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("La capacidad debe ser mayor a 0.");
            capacidadPasajeros = value;
        }
    }

    public Bus(string marca, int velocidadMaxima, string color, int capacidadPasajeros)
        : base(marca, velocidadMaxima, color)
    {
        CapacidadPasajeros = capacidadPasajeros;
    }

    public override void Mover()
    {
        Console.WriteLine($"🚌 El bus {Marca} transporta {CapacidadPasajeros} pasajeros a {VelocidadMaxima} km/h.");
    }

    public override void Describir()
    {
        base.Describir();
        Console.WriteLine($"   Capacidad: {CapacidadPasajeros} pasajeros");
    }
}