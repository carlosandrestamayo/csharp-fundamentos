using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using WinFormsUniversidad.Models;

namespace WinFormsUniversidad.Data
{
    internal class MateriaRepositorio
    {
       
        public static readonly string filePath = "materia.json";
        public List<Materia> Leer()
        {
            List<Materia> lista = new List<Materia>();

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string json = sr.ReadToEnd();

                    if (!string.IsNullOrWhiteSpace(json))
                    {
                        lista = JsonSerializer.Deserialize<List<Materia>>(json) ?? lista;
                    }
                }
            }
            else
            {
                File.Create(filePath).Close();
            }

            return lista;
        }

        private void Guardar(List<Materia> lista)
        {
            // Opciones de serialización
            JsonSerializerOptions opciones = new JsonSerializerOptions
            {
                WriteIndented = true // Hace el JSON más legible (formato bonito)
            };

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                string json = JsonSerializer.Serialize(lista, opciones);

                sw.Write(json);
            }
        }

        public void Agregar(Materia materia)
        {
            List<Materia> lista = this.Leer();

            lista.Add(materia);

            this.Guardar(lista);
        }

        public void Editar(Materia nuevaMateria, string codigo)
        {
            List<Materia> lista = Leer();

            int index = lista.FindIndex(m => m.codigo == codigo);

            if (index != -1)
            {
                lista[index] = nuevaMateria;

                this.Guardar(lista);
            }
        }
    }
}