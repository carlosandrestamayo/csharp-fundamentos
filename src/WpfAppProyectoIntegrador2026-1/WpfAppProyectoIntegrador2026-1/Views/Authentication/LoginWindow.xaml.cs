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

namespace WpfAppProyectoIntegrador2026_1.Views.Authentication
{
    /// <summary>
    /// Lógica de interacción para LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly UsuarioController usuarioController = new UsuarioController();


        public LoginWindow()
        {
            InitializeComponent();
            txtUsername.Focus();

            txtUsername.Text = "1065864163";
            //txtUsername.Text = "admin";
            //txtPassword.TextInput = "admin123";

            txtUsername.KeyDown += TextBox_KeyDown;
            txtPassword.KeyDown += TextBox_KeyDown;
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            Usuario? usuario = usuarioController.Authenticate(txtUsername.Text, txtPassword.Password);

            if (usuario == null)
            {
                MessageBox.Show(
                    "Usuario o contraseña incorrectos.",
                    "Login",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);

                return;
            }

            SessionManager.CurrentUser = usuario;

            MainWindow mainWindow = new MainWindow();

            mainWindow.Show();

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

        //private void BtnLogin_Click(object sender, RoutedEventArgs e)
        //{
        //    this.Close();
        //}
    }
}
