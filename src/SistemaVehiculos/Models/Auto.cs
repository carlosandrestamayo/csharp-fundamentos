// =========================================
//   CLASE HIJA 1: Auto
// =========================================
class Auto : Vehiculo
{
    private int numeroPuertas;

    public int NumeroPuertas
    {
        get { return numeroPuertas; }
        set
        {
            if (value != 2 && value != 4)
                throw new ArgumentException("Un auto solo puede tener 2 o 4 puertas.");
            numeroPuertas = value;
        }
    }

    public Auto(string marca, int velocidadMaxima, string color, int numeroPuertas)
        : base(marca, velocidadMaxima, color)
    {
        NumeroPuertas = numeroPuertas;
    }

    public override void Mover()
    {
        Console.WriteLine($"🚗 El auto {Marca} se desplaza por la carretera a {VelocidadMaxima} km/h.");
    }

    public override void Describir()
    {
        base.Describir();
        Console.WriteLine($"   Puertas: {NumeroPuertas}");
    }
}