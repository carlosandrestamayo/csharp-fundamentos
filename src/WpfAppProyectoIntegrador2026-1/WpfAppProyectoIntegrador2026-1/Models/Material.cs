using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WpfAppProyectoIntegrador2026_1.Models
{
    public class Material
    {
        public Guid Id { get; set; }

        public string Nombre { get; set; }

        // Precio por m³
        public decimal PrecioUnidad { get; set; }

        public string Descripcion { get; set; } = string.Empty;

        public bool Estado { get; set; } = true;

        //[JsonIgnore]
        //public string Estado
        //{

        //    get
        //    {
        //        return Activo ? "Activo" : "Inactivo";
        //    }
        //}

        [JsonConstructor]
        public Material(Guid id, string nombre, decimal precioUnidad, string descripcion, bool estado = true)
        {
            Id = id;
            Nombre = nombre;
            PrecioUnidad = precioUnidad;
            Descripcion = descripcion;
            Estado = estado;
        }
    }
}
