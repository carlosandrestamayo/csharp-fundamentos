using System;
using System.Collections.Generic;
using System.Text;
using WinFormsUniversidad.Models;
using WinFormsUniversidad.Repositorys;

namespace WinFormsUniversidad.Controllers
{
    internal class MateriaController
    {
        private MateriaRepository materiaRepository;

        public MateriaController()
        {
            materiaRepository = new MateriaRepository();
        }

        public List<Materia> ObtenerMaterias()
        {
            return materiaRepository.Leer();
        }

        public void AgregarMateria(Materia materia)
        {
            materiaRepository.Agregar(materia);
        }

        public void EditarMateria(string codigo, string nuevoNombre)
        {
            Materia materiaActualizada = new Materia(codigo, nuevoNombre);
            materiaRepository.Editar(materiaActualizada, codigo);
        }
    }
}
