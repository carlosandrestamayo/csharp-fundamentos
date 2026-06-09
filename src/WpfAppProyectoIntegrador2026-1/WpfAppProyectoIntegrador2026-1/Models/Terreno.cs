using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WpfAppProyectoIntegrador2026_1.Models
{
    public class Terreno
    {
        public Guid Id { get; set; } = Guid.Empty;

        public string Nombre { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public List<Coordenada> Coordenadas { get; set; } = new();

        public decimal Volumen { get; set; } = 0;

        [JsonConstructor]
        public Terreno(Guid id, string nombre, string descripcion, List<Coordenada> coordenadas, decimal volumen)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Coordenadas = coordenadas ?? new();
            Volumen = volumen;
        }

        public Terreno()
        {
        }
    }
}