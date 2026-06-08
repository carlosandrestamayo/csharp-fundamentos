using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfAppProyectoIntegrador2026_1.Controllers;
using WpfAppProyectoIntegrador2026_1.Models;

namespace WpfAppProyectoIntegrador2026_1.Views.Clientes
{
    /// <summary>
    /// Lógica de interacción para EditarClienteWindow.xaml
    /// </summary>
    public partial class EditClienteWindow : Window
    {
        //private Cliente cliente { get; set; }

        private readonly ClienteController clienteController = new ClienteController();

        private readonly Cliente cliente;

        public EditClienteWindow(Cliente cliente)
        {
            InitializeComponent();

            this.cliente = cliente;

            LoadClienteData();

            txtNombre.KeyDown += TextBox_KeyDown;
            txtIdentificacion.KeyDown += TextBox_KeyDown;
            txtTelefono.KeyDown += TextBox_KeyDown;
            txtCorreo.KeyDown += TextBox_KeyDown;
        }

        private void LoadClienteData()
        {
            txtNombre.Text = cliente.Nombre;

            txtIdentificacion.Text = cliente.Identificacion;

            txtTelefono.Text = cliente.Telefono;

            txtCorreo.Text = cliente.Correo;

        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Cliente updatedCliente = new Cliente(cliente.Id, txtNombre.Text, txtIdentificacion.Text, txtTelefono.Text, txtTelefono.Text);
           
            string message = clienteController.Update(updatedCliente);

            //MessageBox.Show(message);

            AlertWindow alertWindow = new AlertWindow("Información", message, AlertType.Info);
            alertWindow.ShowDialog();
            
            if (message == "Cliente updated successfully.")
            {
                Close();
            }

        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                TextBox textBox = sender as TextBox;


                if (textBox != null)
                {
                    textBox.Clear();
                }
            }
        }
    }
}
