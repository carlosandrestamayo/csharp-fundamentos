using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfAppProyectoIntegrador2026_1.Controllers;
using WpfAppProyectoIntegrador2026_1.Models;

namespace WpfAppProyectoIntegrador2026_1.Views.Usuarios
{
    /// <summary>
    /// Lógica de interacción para UsuariosView.xaml
    /// </summary>
    public partial class UsuariosView : UserControl
    {
        private readonly UsuarioController usuarioController = new UsuarioController();

        private List<Usuario> usuariosList = new List<Usuario>();

        public UsuariosView()
        {
            InitializeComponent();

            LoadUsuarios();

            txtSearch.KeyDown += TxtSearch_KeyDown;
        }

        private void LoadUsuarios()
        {
            try
            {
                usuariosList = usuarioController
                                .GetAll()
                                .Where(user => user.Rol == Rol.Operador)
                                .ToList();

                tableUsuarios.ItemsSource = null;

                tableUsuarios.ItemsSource = usuariosList;
            }
            catch (Exception ex)
            {
                AlertWindow alertWindow = new AlertWindow("Error", ex.Message, AlertType.Error);

                alertWindow.ShowDialog();
            }
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string texto = txtSearch.Text.ToLower();

            var filtereds = usuariosList
                .Where(u =>
                    u.Nombre.ToLower().Contains(texto)
                    ||
                    u.Identificacion.ToLower().Contains(texto)
                    ||
                    u.Username.ToLower().Contains(texto)
                )
                .ToList();

            tableUsuarios.ItemsSource = null;

            tableUsuarios.ItemsSource = filtereds;
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                txtSearch.Clear();

                tableUsuarios.ItemsSource = null;

                tableUsuarios.ItemsSource = usuariosList;
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddUsuarioWindow addUsuarioWindow = new AddUsuarioWindow();
            
            addUsuarioWindow.ShowDialog();

            LoadUsuarios();
        }

        
        private void BtnPassword_Click(object sender, RoutedEventArgs e)
        {
            Usuario usuario = (sender as Button).DataContext as Usuario;


            if (usuario != null)
            {
                ChangePasswordWindow changePasswordWindow = new ChangePasswordWindow(usuario);

                changePasswordWindow.ShowDialog();

                LoadUsuarios();
            }
        }

        private void BtnStatus_Click(object sender, RoutedEventArgs e)
        {
            Usuario usuario = (sender as Button).DataContext as Usuario;


            if (usuario == null)
            {
                return;
            }

            string message =
                usuario.Activo
                ? "¿Desea desactivar este usuario?"
                : "¿Desea activar este usuario?";

            MessageBoxResult result =
                MessageBox.Show(
                    message,
                    "Confirmación",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question);

            if (result != MessageBoxResult.Yes)
            {
                return;
            }
                       
            usuarioController.ToggleStatus(usuario.Id);

            LoadUsuarios();
        }
    }
}