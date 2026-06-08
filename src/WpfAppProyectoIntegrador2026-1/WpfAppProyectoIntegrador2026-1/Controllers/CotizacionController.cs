using System;
using System.Collections.Generic;
using System.Text;
using WpfAppProyectoIntegrador2026_1.Models;
using WpfAppProyectoIntegrador2026_1.Repositorys;
using WpfAppProyectoIntegrador2026_1.Validators;

namespace WpfAppProyectoIntegrador2026_1.Controllers
{
    public class CotizacionController
    {

        private CotizacionRepository cotizacionRepository;

        public CotizacionController()
        {
            cotizacionRepository = new CotizacionRepository();
        }
        public List<Cotizacion> GetAll()
        {
            return cotizacionRepository.GetAll();
        }

        public string Add(Cotizacion cotizacion)
        {
            string validationMessage = CotizacionValidator.Validate(cotizacion);


            if (validationMessage != "")
            {
                return validationMessage;
            }

            cotizacionRepository.Add(cotizacion);

            return "Cotizacion added successfully.";
        }

        public string Update(Cotizacion cotizacion)
        {
            string validationMessage = CotizacionValidator.Validate(cotizacion);


            if (validationMessage != "")
            {
                return validationMessage;
            }

            cotizacionRepository.Update(cotizacion, cotizacion.Id);


            return "Cotizacion updated successfully.";
        }

        public void Delete(Guid id)
        {
            cotizacionRepository.Delete(id);
        }

        public Cotizacion? Find(Guid id)
        {
            return cotizacionRepository.Find(id);
        }
    }
}
