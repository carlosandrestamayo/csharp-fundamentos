using System;
using System.Collections.Generic;
using System.Text;
using WpfAppProyectoIntegrador2026_1.Models;
using WpfAppProyectoIntegrador2026_1.Repositorys;
using WpfAppProyectoIntegrador2026_1.Validators;

namespace WpfAppProyectoIntegrador2026_1.Controllers
{
    class MaterialController
    {
        private MaterialRepository materialRepository;

        public MaterialController()
        {
            materialRepository = new MaterialRepository();     
        }

        public List<Material> GetAll()
        {
            return materialRepository.GetAll();
        }

        public string Add(Material material)
        {
            //string validationMessage = MaterialValidator.Validate(material);


            //if (validationMessage != "")
            //{
            //    return validationMessage;
            //}

            materialRepository.Add(material);

            return "Material added successfully.";
        }

        public string Update(Material material)
        {
            //string validationMessage = MaterialValidator.Validate(material);


            //if (validationMessage != "")
            //{
            //    return validationMessage;
            //}

            materialRepository.Update(material, material.Id);


            return "Material updated successfully.";
        }

        public void Delete(Guid id)
        {
            materialRepository.Delete(id);
        }

        public Material? Find(Guid id)
        {
            return materialRepository.Find(id);
        }
    }
}
