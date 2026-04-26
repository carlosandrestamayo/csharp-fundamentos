using System;
using System.Collections.Generic;
using System.Text;

namespace InventarioProductosCategoriaAppWF.Models
{
    internal class Categoria
    {
        // Atributos privados
        private int id;
        private string nombre;

        // Constructor vacío
        public Categoria() { }

        // Constructor con parámetros
        public Categoria(int id, string nombre)
        {
            this.id = id;           // Asigna el id
            this.nombre = nombre;   // Asigna el nombre
        }

        // Método para obtener el id
        public int GetId()
        {
            return this.id;
        }

        // Método para obtener el nombre
        public string GetNombre()
        {
            return this.nombre;
        }

        // Convierte el objeto a texto para guardarlo en archivo
        // Formato: id;nombre
        public override string ToString()
        {
            return this.id + ";" + this.nombre;
        }

        // Convierte una línea de texto en un objeto Categoria
        public static Categoria FromString(string linea)
        {
            // Divide la línea usando ;
            string[] datos = linea.Split(';');

            // Crea el objeto con los datos obtenidos
            return new Categoria(
                int.Parse(datos[0]), // id
                datos[1]             // nombre
            );
        }
    }
}
