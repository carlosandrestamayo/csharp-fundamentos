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
using WpfAppProyectoIntegrador2026_1.Security;
using WpfAppProyectoIntegrador2026_1.Views.Shared;

namespace WpfAppProyectoIntegrador2026_1.Views.Usuarios
{
    /// <summary>
    /// Lógica de interacción para AddUsuarioWindow.xaml
    /// </summary>
    /// 

    
    public partial class AddUsuarioWindow : Window
    {
        UsuarioController usuarioController = new UsuarioController();

        private Cliente? clienteSeleccionado;
        public AddUsuarioWindow()
        {
            InitializeComponent();

            txtPassword.Text = PasswordGenerator.Generate();

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (clienteSeleccionado == null)
                {
                    AlertWindow alert = new AlertWindow("Información", "Debe seleccionar un cliente.", AlertType.Info);

                    alert.ShowDialog();

                    return;
                }

                Usuario usuario = new Usuario(
                    Guid.NewGuid(),
                    clienteSeleccionado.Nombre,
                    clienteSeleccionado.Identificacion,
                    clienteSeleccionado.Telefono,
                    clienteSeleccionado.Correo,
                    clienteSeleccionado.Identificacion,
                    String.Empty,
                    true,
                    Rol.Operador
                );

                string password = txtPassword.Text;

                string message = usuarioController.Add(usuario, password);

                AlertWindow alertWindow = new AlertWindow("Información", message, AlertType.Info);

                alertWindow.ShowDialog();

                if (message == "User registered successfully.")
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                var alertWindow = new AlertWindow("Error", ex.Message, AlertType.Error);

                alertWindow.ShowDialog();
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnSearchCliente_Click(object sender, RoutedEventArgs e)
        {
            SearchClienteWindow searchClienteWindow = new SearchClienteWindow();

            bool? result = searchClienteWindow.ShowDialog();

            if (result == true)
            {
                clienteSeleccionado = searchClienteWindow.SelectedCliente;

                txtNombre.Text = clienteSeleccionado.Nombre;


                txtIdentificacion.Text = clienteSeleccionado.Identificacion;


                txtUsername.Text = clienteSeleccionado.Identificacion;

            }
        }
    }
}
