using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using WpfAppProyectoIntegrador2026_1.Models.Enums;

namespace WpfAppProyectoIntegrador2026_1.Models
{
    public class Cotizacion
    {
        public Guid Id { get; set; } = Guid.Empty;

        public int Numero { get; set; }

        public Cliente? Cliente { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public EstadoCotizacion Estado { get; set; } = EstadoCotizacion.Activa;

        public List<CotizacionDetalle> Detalles { get; set; } =
            new();

        [JsonIgnore]
        public decimal Total
        {
            get
            {
                return Detalles.Sum(detalle => detalle.Subtotal);
            }
        }

        [JsonIgnore]
        public string FormattedNumber
        {
            get
            {
                return $"COT-{Numero:D6}";
            }
        }

        [JsonIgnore]
        public int DetailsCount
        {
            get
            {
                return Detalles.Count;
            }
        }

        [JsonConstructor]
        public Cotizacion(
            Guid id,
            int numero,
            Cliente? cliente,
            DateTime fecha,
            EstadoCotizacion estado,
            List<CotizacionDetalle> detalles)
        {
            Id = id;
            Numero = numero;
            Cliente = cliente;
            Fecha = fecha;
            Estado = estado;
            Detalles = detalles ?? new();
        }

        public Cotizacion()
        {
        }
    }

}