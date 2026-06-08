using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppProyectoIntegrador2026_1.Models
{
    public class Cotizacion
    {
        public Guid Id { get; set; }

        // Consecutivo visible para el usuario
        public int Numero { get; set; }

        public Cliente Cliente { get; set; }

        // Volumen calculado del terreno
        public decimal Volumen { get; set; }

        // Total de la cotización
        public decimal Total { get; set; }

        // Fecha de creación
        public DateTime Fecha { get; set; }

        public EstadoCotizacion Estado { get; set; }

        public List<CotizacionDetalle> Detalles { get; set; }

        public Cotizacion()
        {
            //Cliente = new Cliente();

            Detalles = new List<CotizacionDetalle>();

            Fecha = DateTime.Now;
        }

        public Cotizacion(
            Guid id,
            int numero,
            Cliente cliente,
            decimal volumen,
            EstadoCotizacion estado,
            List<CotizacionDetalle> detalles
        )
        {
            Id = id;

            Numero = numero;

            Cliente = cliente;

            Volumen = volumen;

            Estado = estado;

            Fecha = DateTime.Now;

            Detalles = detalles;

            Total = detalles.Sum(detalle => detalle.Subtotal);


        }
    }
    public enum EstadoCotizacion
    {
        Activa,

        Inactiva,

        Facturada
    }
}
