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
    /// Lógica de interacción para AgregarClienteWindow.xaml
    /// </summary>
    public partial class AddClienteWindow : Window
    {
        private readonly ClienteController clienteController = new ClienteController();


        public AddClienteWindow()
        {
            InitializeComponent();
            txtNombre.Focus();
            txtNombre.KeyDown += TextBox_KeyDown;
            txtIdentificacion.KeyDown += TextBox_KeyDown;
            txtTelefono.KeyDown += TextBox_KeyDown;
            txtCorreo.KeyDown += TextBox_KeyDown;
        }

        private void BtnSave_Click(object sender,
                               RoutedEventArgs e)
        {
            Cliente cliente = new Cliente(Guid.NewGuid(), txtNombre.Text, txtIdentificacion.Text, txtTelefono.Text, txtCorreo.Text);         
            
            string message = clienteController.Add(cliente);

            MessageBox.Show(message);

            if (message == "Cliente added successfully.")
            {
                Close();
            }
        }

        private void BtnCancel_Click(object sender,
                                RoutedEventArgs e)
        {
            Close();
        }

        private void TextBox_KeyDown(object sender,
                                     KeyEventArgs e)
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


        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("BtnGuardar_Click");
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("BtnCancelar_Click");
        }
    }
}
