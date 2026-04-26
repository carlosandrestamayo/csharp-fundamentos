using InventarioProductosCategoriaAppWF.Controllers;
using InventarioProductosCategoriaAppWF.Models;
using InventarioProductosCategoriaAppWF.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventarioProductosCategoriaAppWF
{
    public partial class FormMain : Form
    {
        // 🔗 Controladores
        private ProductoController productoController = new ProductoController();
        private CategoriaController categoriaController = new CategoriaController();

        // 🏗️ Constructor
        public FormMain()
        {
            InitializeComponent();

            // 🔄 Cargar categorías al iniciar
            CargarCategorias();
        }

        // 📥 Leer datos del formulario y construir el objeto Producto
        private Producto LeerFormulario()
        {
            // 🔹 Obtener categoría seleccionada
            Categoria categoria = (Categoria)cmbCategoria.SelectedItem;

            // 🔹 Crear el producto con todos los datos
            Producto producto = new Producto(
                txtCodigo.Text,
                txtNombre.Text,
                int.Parse(txtCantidad.Text),
                double.Parse(txtPrecio.Text),
                categoria
            );

            return producto;
        }

        // 🧹 Limpiar campos
        private void Limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();

            cmbCategoria.SelectedIndex = -1; // limpia selección

            txtCodigo.Focus(); // vuelve al primer campo
        }

        // 🔄 Cargar categorías en el ComboBox
        private void CargarCategorias()
        {
            cmbCategoria.Items.Clear();

            // 📋 Obtener categorías desde el controller
            List<Categoria> lista = categoriaController.Listar();

            foreach (Categoria categoria in lista)
            {
                // Agrega el objeto completo
                cmbCategoria.Items.Add(categoria);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = this.LeerFormulario();

                productoController.Guardar(producto);

                MessageBox.Show("Producto guardado correctamente");

                this.Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = this.LeerFormulario();

                productoController.Editar(producto);

                MessageBox.Show("Producto actualizado");

                this.Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bthLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listBoxProductos.Items.Clear();

            List<Producto> lista = productoController.ListarOrdenado();

            foreach (Producto producto in lista)
            {
                // Mostrar producto + categoría
                listBoxProductos.Items.Add(
                    producto.GetCodigo() + " - " +
                    producto.GetNombre() + " - " +
                    producto.GetCantidad() + " - $" +
                    producto.GetPrecio() + " - " +
                    producto.GetCategoria().GetNombre()
                );
            }
        }

        private void listBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProductos.SelectedItem == null)
                return;

            string linea = listBoxProductos.SelectedItem.ToString();

            // Formato:
            // codigo - nombre - cantidad - precio - categoria
            string[] datos = linea.Split('-');

            txtCodigo.Text = datos[0].Trim();
            txtNombre.Text = datos[1].Trim();
            txtCantidad.Text = datos[2].Trim();
            txtPrecio.Text = datos[3].Replace("$", "").Trim();

            string nombreCategoria = datos[4].Trim();

            // 🔍 Seleccionar la categoría en el ComboBox
            foreach (Categoria categoria in cmbCategoria.Items)
            {
                if (categoria.GetNombre() == nombreCategoria)
                {
                    cmbCategoria.SelectedItem = categoria;
                    break;
                }
            }
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FormCategoria form = new FormCategoria();

            // Abre como ventana modal (bloquea el form principal)
            form.ShowDialog();

            // 🔄 Recargar categorías al cerrar
            CargarCategorias();
        }
    }
}
