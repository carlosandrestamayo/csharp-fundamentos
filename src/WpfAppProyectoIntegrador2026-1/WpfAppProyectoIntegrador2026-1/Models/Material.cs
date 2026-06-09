using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WpfAppProyectoIntegrador2026_1.Models
{
    public class Material
    {
        public Guid Id { get; set; }  = Guid.Empty;

        public string Nombre { get; set; } = string.Empty;

        public decimal PrecioUnidad { get; set; } = 0;

        public string Descripcion { get; set; } = string.Empty;

        public bool Activo { get; set; } = true;

        
        [JsonIgnore]
        public string Estado
        {
            get
            {
                return Activo ? "Activo" : "Inactivo";
            }
        }

        [JsonConstructor]
        public Material(Guid id, string nombre, decimal precioUnidad, string descripcion, bool activo = true)
        {
            Id = id;
            Nombre = nombre;
            PrecioUnidad = precioUnidad;
            Descripcion = descripcion;
            Activo = activo;
        }

        public Material()
        {
            
        }
    }
}
