using System;
using System.Text.Json.Serialization;

namespace WpfAppProyectoIntegrador2026_1.Models
{
    public class CotizacionDetalle
    {
        public Guid Id { get; set; } = Guid.Empty;

        public int Cantidad { get; set; } = 1;

        public TerrenoFile Terreno { get; set; } = new();

        public Material Material { get; set; } = new();

        //[JsonIgnore]
        //public decimal Volumen
        //{
        //    get
        //    {
        //        return Terreno.Volumen;
        //    }
        //}

        [JsonIgnore]
        public decimal VolumenUnitario
        {
            get
            {
                return Terreno.Volumen;
            }
        }

        [JsonIgnore]
        public decimal VolumenTotal
        {
            get
            {
                return Cantidad * VolumenUnitario;
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
                return VolumenTotal * PrecioUnidad;
            }
        }

        [JsonConstructor]
        public CotizacionDetalle(Guid id,int cantidad, TerrenoFile terreno, Material material)
        {
            Id = id;
            Cantidad = cantidad;
            Terreno = terreno ?? new();
            Material = material ?? new();
        }

        public CotizacionDetalle()
        {
        }
    }
}