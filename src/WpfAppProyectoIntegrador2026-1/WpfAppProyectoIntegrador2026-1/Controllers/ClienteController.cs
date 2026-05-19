using System;
using System.Collections.Generic;
using System.Text;
using WpfAppProyectoIntegrador2026_1.Models;
using WpfAppProyectoIntegrador2026_1.Repositorys;
using WpfAppProyectoIntegrador2026_1.Validators;

namespace WpfAppProyectoIntegrador2026_1.Controllers
{
    public class ClienteController
    {
        private ClienteRepository clienteRepository;

        public ClienteController()
        {
            clienteRepository = new ClienteRepository();
        }

        public List<Cliente> GetAll()
        {
            return clienteRepository.GetAll();
        }

        public string Add(Cliente cliente)
        {
            string validationMessage = ClienteValidator.Validate(cliente);


            if (validationMessage != "")
            {
                return validationMessage;
            }

            clienteRepository.Add(cliente);

            return "Cliente added successfully.";
        }

        public string Update(Cliente cliente)
        {
            string validationMessage = ClienteValidator.Validate(cliente);


            if (validationMessage != "")
            {
                return validationMessage;
            }

            clienteRepository.Update(cliente, cliente.Id);


            return "Cliente updated successfully.";
        }

        public void Delete(Guid id)
        {
            clienteRepository.Delete(id);
        }

        public Cliente? Find(Guid id)
        {
            return clienteRepository.Find(id);
        }
    }
}
