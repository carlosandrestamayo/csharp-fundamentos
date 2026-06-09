using System;
using System.Text.Json.Serialization;

namespace WpfAppProyectoIntegrador2026_1.Models
{
    public class CotizacionDetalle
    {
        public Guid Id { get; set; } = Guid.Empty;

        public Terreno Terreno { get; set; } = new();

        public Material Material { get; set; } = new();

        [JsonIgnore]
        public decimal Volumen
        {
            get
            {
                return Terreno.Volumen;
            }
        }

        [JsonIgnore]
        public decimal PrecioUnidad
        {
            get
            {
                return Material.PrecioUnidad;
            }
        }

        [JsonIgnore]
        public decimal Subtotal
        {
            get
            {
                return Volumen * PrecioUnidad;
            }
        }

        [JsonConstructor]
        public CotizacionDetalle(Guid id, Terreno terreno, Material material)
        {
            Id = id;
            Terreno = terreno ?? new();
            Material = material ?? new();
        }

        public CotizacionDetalle()
        {
        }
    }
}