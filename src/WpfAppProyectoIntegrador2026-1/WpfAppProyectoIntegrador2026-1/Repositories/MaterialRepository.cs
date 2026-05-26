using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WpfAppProyectoIntegrador2026_1.Models;

namespace WpfAppProyectoIntegrador2026_1.Repositorys
{
    class MaterialRepository
    {
        private static readonly string folder = "Data";
        private static readonly string filePath = Path.Combine(folder, "material.json");

        JsonRepository<Material> jsonRepository = new JsonRepository<Material>(folder, filePath);

        public List<Material> GetAll()
        {
            return jsonRepository.GetAll();
        }


        public void Add(Material material)
        {
            List<Material> lista = jsonRepository.GetAll();

            lista.Add(material);

            jsonRepository.Save(lista);
        }


        public void Update(Material newMaterial, Guid id)
        {
            jsonRepository.Update(newMaterial, material => material.Id == id);
        }

        public void Delete(Guid id)
        {
            jsonRepository.Delete(material => material.Id == id);
        }

        public Material? Find(Guid id)
        {
            return jsonRepository.Find(material => material.Id == id);
        }
     
    }
}
