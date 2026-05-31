using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WpfAppProyectoIntegrador2026_1.Models
{
    public class Usuario : Persona
    {
        public string Username { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public bool Activo { get; set; }

        public Rol Rol { get; set; }

        public DateTime CreatedAt { get; set; }

        [JsonIgnore]
        public string Estado{
            
            get
            {
                return Activo ? "Activo" : "Inactivo";
            }
        }

        [JsonConstructor]
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
        ) : base(id,
                 nombre,
                 identificacion,
                 telefono,
                 correo)
        {
            Username = username;

            PasswordHash = passwordHash;

            Activo = activo;

            Rol = rol;

            CreatedAt = DateTime.Now;
        }
    }

    public enum Rol
    {
        Administrador,
        Operador
    }
}
