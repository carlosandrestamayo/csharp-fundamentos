using System.Text.RegularExpressions;

namespace WpfAppProyectoIntegrador2026_1.Validators
{
    public static class PasswordValidator
    {
        public static void Validate(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new Exception(
                    "La contraseña es obligatoria."
                );
            }

            if (password.Length < 8)
            {
                throw new Exception(
                    "La contraseña debe tener mínimo 8 caracteres."
                );
            }

            if (!Regex.IsMatch(password, "[A-Z]"))
            {
                throw new Exception(
                    "La contraseña debe contener una letra mayúscula."
                );
            }

            if (!Regex.IsMatch(password, "[0-9]"))
            {
                throw new Exception(
                    "La contraseña debe contener un número."
                );
            }

            if (!Regex.IsMatch(password, @"[^a-zA-Z0-9]"))
            {
                throw new Exception(
                    "La contraseña debe contener un carácter especial."
                );
            }
        }
    }
}