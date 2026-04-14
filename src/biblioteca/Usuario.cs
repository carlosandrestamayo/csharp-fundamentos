// Clase que representa un usuario del sistema
class Usuario
{
    // Atributo privado para almacenar el nombre
    private string nombre;

    // Propiedad pública para acceder y modificar el nombre
    public string Nombre
    {
        get { return this.nombre; }
        set { this.nombre = value; }
    }

    // Constructor: inicializa el nombre del usuario
    public Usuario(string nombre)
    {
        this.nombre = nombre;
    }

    // Método para mostrar la información del usuario
    public void MostrarUsuario()
    {
        Console.WriteLine("Usuario: " + this.nombre);
    }
}
