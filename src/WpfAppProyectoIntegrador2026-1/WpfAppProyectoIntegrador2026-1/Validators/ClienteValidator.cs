using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using WpfAppProyectoIntegrador2026_1.Models;

namespace WpfAppProyectoIntegrador2026_1.Validators
{
    internal class ClienteValidator
    {
        public static string Validate(Cliente cliente)
        {
            // =========================================
            // NAME
            // =========================================

            if (string.IsNullOrWhiteSpace(cliente.Nombre))
            {
                return "Name is required.";
            }

            if (cliente.Nombre.Length < 3)
            {
                return "Name must contain at least 3 characters.";
            }

            // =========================================
            // IDENTIFICATION
            // =========================================

            if (string.IsNullOrWhiteSpace(cliente.Identificacion))
            {
                return "Identification is required.";
            }

            string identificationPattern =
                @"^[0-9\-]+$";

            if (!Regex.IsMatch(cliente.Identificacion,
                               identificationPattern))
            {
                return "Identification can only contain numbers and hyphens.";
            }

            if (cliente.Identificacion.Length < 5)
            {
                return "Invalid identification.";
            }

            // =========================================
            // PHONE
            // =========================================

            if (string.IsNullOrWhiteSpace(cliente.Telefono))
            {
                return "Phone number is required.";
            }

            string phonePattern =
                @"^[0-9]+$";

            if (!Regex.IsMatch(cliente.Telefono,
                               phonePattern))
            {
                return "Phone number can only contain numbers.";
            }

            if (cliente.Telefono.Length < 7 ||
                cliente.Telefono.Length > 10)
            {
                return "Invalid phone number.";
            }

            // =========================================
            // EMAIL
            // =========================================

            if (string.IsNullOrWhiteSpace(cliente.Correo))
            {
                return "Email is required.";
            }

            string emailPattern =
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(cliente.Correo,
                               emailPattern))
            {
                return "Invalid email format.";
            }

            // =========================================
            // VALID
            // =========================================

            return "";
        }

    }
}
