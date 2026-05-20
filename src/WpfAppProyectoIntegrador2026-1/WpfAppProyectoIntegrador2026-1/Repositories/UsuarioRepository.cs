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

        public List<Usuario> Leer()
        {
            return jsonRepository.Leer();
        }


        public void Agregar(Usuario usuario)
        {
            List<Usuario> lista = jsonRepository.Leer();

            lista.Add(usuario);

            jsonRepository.Guardar(lista);
        }

        public void Editar(Usuario nuevoUsuario, string codigo)
        {
            //jsonRepository.Editar(nuevaUsuario, m => m.codigo == codigo);

        }

        public Usuario? Buscar(string codigo)
        {
            return null;
            //return jsonRepository.Buscar(m => m.codigo == codigo);
        }
    }
}
