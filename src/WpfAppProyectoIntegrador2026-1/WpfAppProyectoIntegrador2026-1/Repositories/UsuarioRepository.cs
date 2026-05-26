using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WpfAppProyectoIntegrador2026_1.Models;

namespace WpfAppProyectoIntegrador2026_1.Repositorys
{
    public class UsuarioRepository
    {
        private static readonly string folder = "Data";
        private static readonly string filePath = Path.Combine(folder, "usuario.json");

        JsonRepository<Usuario> jsonRepository = new JsonRepository<Usuario>(folder, filePath);

        public List<Usuario> GetAll()
        {
            return jsonRepository.GetAll();   
        }


        public void Add(Usuario usuario)
        {
            List<Usuario> lista = jsonRepository.GetAll();

            lista.Add(usuario);

            jsonRepository.Save(lista);
        }

        public void Update(Usuario nuevoUsuario, string codigo)
        {
            //jsonRepository.Editar(nuevaUsuario, m => m.codigo == codigo);

        }

        public Usuario? Find(Guid id)
        {
            return jsonRepository.Find(
                usuario => usuario.Id == id
            );
        }

        
        public Usuario? FindByUsername(string username)
        {
            return jsonRepository.Find(
                usuario =>
                    usuario.Username
                        .ToLower() == username.ToLower()
            );
        }
    }
}
