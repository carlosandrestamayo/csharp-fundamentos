using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text;
using WpfAppProyectoIntegrador2026_1.Models;

namespace WpfAppProyectoIntegrador2026_1.Repositorys
{
    public class ClienteRepository
    {
        private static readonly string folder = "Data";
        private static readonly string filePath = Path.Combine(folder, "cliente.json");

        JsonRepository<Cliente> jsonRepository = new JsonRepository<Cliente>(folder, filePath);

        public List<Cliente> GetAll()
        {
            return jsonRepository.GetAll();
        }

        public void Add(Cliente cliente)
        {
            List<Cliente> list = jsonRepository.GetAll();

            list.Add(cliente);

            jsonRepository.Save(list);
        }

        public void Update(Cliente newCliente, Guid id)
        {
            jsonRepository.Update(newCliente, cliente => cliente.Id == id);
        }

        public void Delete(Guid id)
        {
            jsonRepository.Delete(cliente => cliente.Id == id);
        }

        public Cliente? Find(Guid id)
        {
            return jsonRepository.Find(cliente => cliente.Id == id);
        }
    }
}
