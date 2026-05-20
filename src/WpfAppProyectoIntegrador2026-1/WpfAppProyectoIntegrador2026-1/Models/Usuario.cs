using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppProyectoIntegrador2026_1.Models
{
    public class Usuario : Persona
    {
        public string Username { get; set; }

        public string PasswordHash { get; set; }

        public bool Activo { get; set; }

        public Rol Rol { get; set; }

        public Usuario(
            Guid id,
            string nombre,
            string identificacion,
            string telefono,
            string correo,
            string username,
            string passwordHash,
            bool activo,
            Rol rol
        ) : base(
                id,
                nombre,
                identificacion,
                telefono,
                correo
            )
        {
            Username = username;
            PasswordHash = passwordHash;
            Activo = activo;
            Rol = rol;
        }
    }

    public enum Rol
    {
        Administrador,
        Operador
    }
}
