using InventarioProductosCategoriaAppWF.Controllers;
using InventarioProductosCategoriaAppWF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventarioProductosCategoriaAppWF.Views
{
    public partial class FormCategoria : Form
    {
        // 🔗 Controlador de categorías
        private CategoriaController controller = new CategoriaController();

        // 🏗️ Constructor
        public FormCategoria()
        {
            InitializeComponent();
        }

        // 📥 Método para leer datos del formulario
        private Categoria LeerFormulario()
        {
            Categoria categoria = new Categoria(
                int.Parse(txtId.Text), // Convierte el texto a entero
                txtNombre.Text         // Nombre de la categoría
            );

            return categoria;
        }

        // 🧹 Limpiar campos
        private void Limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();

            txtId.Focus(); // coloca el cursor en el id
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear objeto desde los datos ingresados
                Categoria categoria = LeerFormulario();

                // Guardar usando el controlador
                controller.Guardar(categoria);

                MessageBox.Show("Categoría guardada correctamente");

                Limpiar(); // limpiar campos
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            // Limpiar lista antes de cargar
            listBoxCategorias.Items.Clear();

            // Obtener todas las categorías
            var lista = controller.Listar();

            // Recorrer y mostrar
            foreach (Categoria categoria in lista)
            {
                listBoxCategorias.Items.Add(
                    categoria.GetId() + " - " +
                    categoria.GetNombre()
                );
            }
        }

        private void listBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si no hay selección, salir
            if (listBoxCategorias.SelectedItem == null)
                return;

            string linea = listBoxCategorias.SelectedItem.ToString();

            // Formato: id - nombre
            string[] datos = linea.Split('-');

            // Asignar valores a los TextBox
            txtId.Text = datos[0].Trim();
            txtNombre.Text = datos[1].Trim();
        }
    }
}
