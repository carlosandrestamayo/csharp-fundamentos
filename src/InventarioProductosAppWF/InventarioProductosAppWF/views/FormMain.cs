using InventarioProductosAppWF.controllers;
using InventarioProductosAppWF.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventarioProductosAppWF.views
{
    public partial class FormMain : Form
    {
        // 🔹 Instancia del controlador (conecta la vista con la lógica)
        private ProductoController controller = new ProductoController();

        // 🏗️ Constructor del formulario
        public FormMain()
        {
            InitializeComponent(); // Inicializa los controles del formulario
        }

        // 📥 Método para leer los datos ingresados en el formulario
        private Producto LeerFormulario()
        {
            // Se crea un objeto Producto con los valores de los TextBox
            Producto producto = new Producto(
                txtCodigo.Text,                   // Código del producto
                txtNombre.Text,                   // Nombre del producto
                int.Parse(txtCantidad.Text),      // Cantidad (convertido a entero)
                double.Parse(txtPrecio.Text)      // Precio (convertido a double)
            );

            return producto; // Se retorna el objeto construido
        }

        // 🧹 Método para limpiar los campos del formulario
        private void Limpiar()
        {
            txtCodigo.Clear();   // Limpia el campo código
            txtNombre.Clear();   // Limpia el campo nombre
            txtCantidad.Clear(); // Limpia el campo cantidad
            txtPrecio.Clear();   // Limpia el campo precio

            txtCodigo.Focus();   // Coloca el cursor en el campo código
        }

        // ➕ Evento del botón AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se leen los datos del formulario
                Producto producto = LeerFormulario();

                // Se envía el producto al controlador para guardarlo
                controller.Guardar(producto);

                MessageBox.Show("Producto guardado correctamente");

                // Se limpian los campos
                Limpiar();
            }
            catch (Exception ex)
            {
                // Si ocurre un error (validación, conversión, etc.)
                MessageBox.Show(ex.Message);
            }
        }

        // ✏️ Evento del botón EDITAR
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se leen los datos del formulario
                Producto producto = LeerFormulario();

                // Se envía al controlador para actualizarlo
                controller.Editar(producto);

                MessageBox.Show("Producto actualizado");

                // Se limpian los campos
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 🧼 Evento del botón LIMPIAR
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar(); // Llama al método limpiar
        }

        // 📋 Evento del botón LISTAR
        private void btnListar_Click(object sender, EventArgs e)
        {
            // Limpia la lista antes de cargar nuevos datos
            listBoxProductos.Items.Clear();

            // Obtiene la lista de productos ordenados desde el controlador
            var lista = controller.ListarOrdenado();

            // Recorre cada producto y lo muestra en el ListBox
            foreach (Producto producto in lista)
            {
                listBoxProductos.Items.Add(
                    producto.GetCodigo() + " - " +
                    producto.GetNombre() + " - " +
                    producto.GetCantidad() + " - $" +
                    producto.GetPrecio()
                );
            }
        }

        // 👆 Evento cuando se selecciona un elemento del ListBox
        private void listBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si no hay nada seleccionado, no hace nada
            if (listBoxProductos.SelectedItem == null)
                return;

            // Obtiene el texto del elemento seleccionado
            string linea = listBoxProductos.SelectedItem.ToString();

            // Formato esperado: codigo - nombre - cantidad - precio
            string[] datos = linea.Split('-');

            // Se asignan los valores a los TextBox
            txtCodigo.Text = datos[0].Trim();
            txtNombre.Text = datos[1].Trim();
            txtCantidad.Text = datos[2].Trim();
            txtPrecio.Text = datos[3].Replace("$", "").Trim();
        }
    }
}