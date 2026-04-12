// =========================================
//   CLASE BASE (Clase Padre)
// =========================================
// Archivo: Models/Vehiculo.cs
// No necesitas using System ni namespace explícito

abstract class Vehiculo
{
    private string marca;
    private int velocidadMaxima;
    private string color;

    public string Marca
    {
        get { return marca; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("La marca no puede estar vacía.");
            marca = value;
        }
    }

    public int VelocidadMaxima
    {
        get { return velocidadMaxima; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("La velocidad debe ser mayor a 0.");
            velocidadMaxima = value;
        }
    }

    public string Color
    {
        get { return color; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El color no puede estar vacío.");
            color = value;
        }
    }

    public Vehiculo(string marca, int velocidadMaxima, string color)
    {
        Marca           = marca;
        VelocidadMaxima = velocidadMaxima;
        Color           = color;
    }

    public void Encender()
    {
        Console.WriteLine($"🔑 El vehículo {Marca} está encendido.");
    }

    public abstract void Mover();

    public virtual void Describir()
    {
        Console.WriteLine($"🚘 Vehículo: {Marca} | Color: {Color} | Vel. Máx: {VelocidadMaxima} km/h");
    }
}