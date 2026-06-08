using System.Text.RegularExpressions;
using WpfAppProyectoIntegrador2026_1.Models;

public class ClienteValidator
{
    public static string Validate(Cliente cliente)
    {
        if (string.IsNullOrWhiteSpace(cliente.Nombre))
        {
            return "Name is required.";
        }

        if (cliente.Nombre.Length < 3)
        {
            return "Name must contain at least 3 characters.";
        }

        if (string.IsNullOrWhiteSpace(cliente.Identificacion))
        {
            return "Identification is required.";
        }

        if (!Regex.IsMatch(cliente.Identificacion, @"^[0-9\-]+$"))
        {
            return "Identification can only contain numbers and hyphens.";
        }

        if (cliente.Identificacion.Length < 5)
        {
            return "Invalid identification.";
        }

        if (string.IsNullOrWhiteSpace(cliente.Telefono))
        {
            return "Phone number is required.";
        }

        if (!Regex.IsMatch(cliente.Telefono, @"^[0-9]+$"))
        {
            return "Phone number can only contain numbers.";
        }

        if (cliente.Telefono.Length < 7 || cliente.Telefono.Length > 10)

        {
            return "Invalid phone number.";
        }

        if (string.IsNullOrWhiteSpace(cliente.Correo))
        {
            return "Email is required.";
        }

        if (!Regex.IsMatch(
                cliente.Correo,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
        {
            return "Invalid email format.";
        }

        return string.Empty;
    }
}