class Usuario
{
    private string nombre;
    
    public string Nombre
    {
        get { return this.nombre; }
        set { this.nombre = value; }
    }

    public Usuario(string nombre)
    {
        this.nombre = nombre;
    }

    public void MostrarUsuario()
    {
        Console.WriteLine("Usuario: " + this.nombre);
    }
}