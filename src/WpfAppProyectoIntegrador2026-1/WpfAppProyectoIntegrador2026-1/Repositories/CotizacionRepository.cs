using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WpfAppProyectoIntegrador2026_1.Models;

namespace WpfAppProyectoIntegrador2026_1.Repositorys
{
    public class CotizacionRepository
    {
        private static readonly string folder = "Data";
        private static readonly string filePath = Path.Combine(folder, "cotizacion.json");

        JsonRepository<Cotizacion> jsonRepository = new JsonRepository<Cotizacion>(folder, filePath);

        public List<Cotizacion> GetAll()
        {
            return jsonRepository.GetAll();
        }

        public void Add(Cotizacion cotizacion)
        {
            List<Cotizacion> list = jsonRepository.GetAll();

            list.Add(cotizacion);

            jsonRepository.Save(list);
        }

        public void Update(Cotizacion newCotizacion, Guid id)
        {
            jsonRepository.Update(newCotizacion, cotizacion => cotizacion.Id == id);
        }

        public void Delete(Guid id)
        {
            jsonRepository.Delete(cotizacion => cotizacion.Id == id);
        }

        public Cotizacion? Find(Guid id)
        {
            return jsonRepository.Find(cotizacion => cotizacion.Id == id);
        }
    }
}
