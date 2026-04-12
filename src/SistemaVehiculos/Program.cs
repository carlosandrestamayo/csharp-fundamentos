// =========================================
//   PROGRAMA PRINCIPAL
// =========================================
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===========================================");
        Console.WriteLine("     SISTEMA DE VEHÍCULOS - POO en C#     ");
        Console.WriteLine("===========================================\n");

        Auto auto = new Auto("Toyota",  180, "Rojo",     4);
        Moto moto = new Moto("Honda",   220, "Negro",    false);
        Bus  bus  = new Bus("Mercedes", 120, "Amarillo", 50);

        // --- HERENCIA: todos usan Encender() del padre ---
        Console.WriteLine(">> Encendiendo vehículos (método heredado):");
        auto.Encender();
        moto.Encender();
        bus.Encender();

        // --- POLIMORFISMO: lista de tipo base ---
        Console.WriteLine("\n>> Descripción de cada vehículo (polimorfismo):");
        List<Vehiculo> flota = new List<Vehiculo> { auto, moto, bus };

        foreach (Vehiculo v in flota)
        {
            v.Describir();
            Console.WriteLine();
        }

        Console.WriteLine(">> Moviendo los vehículos (polimorfismo):");
        foreach (Vehiculo v in flota)
        {
            v.Mover();
        }

        // --- ENCAPSULAMIENTO: validación en acción ---
        Console.WriteLine("\n>> Probando validación del encapsulamiento:");
        try
        {
            auto.VelocidadMaxima = -50; // ❌ Debe lanzar excepción
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"⚠️  Error capturado: {e.Message}");
        }

        auto.Color = "Azul"; // ✅ Cambio válido via propiedad
        Console.WriteLine($"✅ Color del auto actualizado a: {auto.Color}");

        Console.WriteLine("\n===========================================");
        Console.WriteLine("  ✅ Encapsulamiento, Herencia y           ");
        Console.WriteLine("     Polimorfismo demostrados correctamente!");
        Console.WriteLine("===========================================");
    }
}