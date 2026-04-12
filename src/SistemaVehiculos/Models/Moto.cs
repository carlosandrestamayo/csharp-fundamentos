// =========================================
//   CLASE HIJA 2: Moto
// =========================================
class Moto : Vehiculo
{
    private bool tieneSidecar;

    public bool TieneSidecar
    {
        get { return tieneSidecar; }
        set { tieneSidecar = value; }
    }

    public Moto(string marca, int velocidadMaxima, string color, bool tieneSidecar)
        : base(marca, velocidadMaxima, color)
    {
        TieneSidecar = tieneSidecar;
    }

    public override void Mover()
    {
        Console.WriteLine($"🏍️  La moto {Marca} zigzaguea ágilmente a {VelocidadMaxima} km/h.");
    }

    public override void Describir()
    {
        base.Describir();
        Console.WriteLine($"   Sidecar: {(TieneSidecar ? "Sí" : "No")}");
    }
}