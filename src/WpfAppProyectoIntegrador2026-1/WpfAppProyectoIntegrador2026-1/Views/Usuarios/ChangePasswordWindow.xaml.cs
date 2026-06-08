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

namespace WpfAppProyectoIntegrador2026_1.Views.Usuarios
{
    /// <summary>
    /// Lógica de interacción para ChangePasswordWindow.xaml
    /// </summary>
    public partial class ChangePasswordWindow : Window
    {
        private readonly UsuarioController usuarioController = new UsuarioController();


        private readonly Usuario usuario;
        public ChangePasswordWindow(Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;

            LoadUserData();

            GeneratePassword();
        }

        private void LoadUserData()
        {
            txtNombre.Text = usuario.Nombre;

            txtIdentificacion.Text = usuario.Identificacion;

            txtUsername.Text = usuario.Username;

        }

        private void GeneratePassword()
        {
            txtPassword.Text = PasswordGenerator.Generate();
        }

        private void BtnGeneratePassword_Click(object sender, RoutedEventArgs e)
        {
            GeneratePassword();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string password = txtPassword.Text;

                usuarioController.ResetPassword(usuario.Id, password);
                
                AlertWindow alertWindow = new AlertWindow("Información", "La contraseña fue restablecida correctamente.", AlertType.Info);

                alertWindow.ShowDialog();

                Close();
            }
            catch (Exception ex)
            {
                AlertWindow alert = new AlertWindow("Error", ex.Message, AlertType.Error);

                alert.ShowDialog();
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
             
    }
}
