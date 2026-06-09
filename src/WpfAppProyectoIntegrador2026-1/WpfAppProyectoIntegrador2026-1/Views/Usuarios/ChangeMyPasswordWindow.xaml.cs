using System;
using System.Windows;
using WpfAppProyectoIntegrador2026_1.Controllers;
using WpfAppProyectoIntegrador2026_1.Models.Enums;
using WpfAppProyectoIntegrador2026_1.Security;

namespace WpfAppProyectoIntegrador2026_1.Views.Authentication
{
    public partial class ChangeMyPasswordWindow : Window
    {
        private readonly UsuarioController usuarioController =
            new UsuarioController();

        public ChangeMyPasswordWindow()
        {
            InitializeComponent();

            LoadUserData();
        }

        private void LoadUserData()
        {
            if (SessionManager.CurrentUser == null)
            {
                Close();

                return;
            }

            txtUsername.Text =
                SessionManager.CurrentUser.Username;
        }

        private void BtnGeneratePassword_Click(
            object sender,
            RoutedEventArgs e)
        {
            string password =
                PasswordGenerator.Generate();

            txtNewPassword.Password =
                password;

            txtConfirmPassword.Password =
                password;

            lblGeneratedPassword.Text =
                $"Contraseña generada: {password}";

            lblGeneratedPassword.Visibility =
                Visibility.Visible;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtNewPassword.Password !=
                    txtConfirmPassword.Password)
                {
                    throw new Exception(
                        "Las contraseñas no coinciden."
                    );
                }

                usuarioController.ChangePassword(
                    SessionManager.CurrentUser.Id,
                    txtCurrentPassword.Password,
                    txtNewPassword.Password
                );

                AlertWindow alert =
                    new AlertWindow(
                        "Información",
                        "La contraseña fue actualizada correctamente.", AlertType.Info
                    );

                alert.ShowDialog();

                Close();
            }
            catch (Exception ex)
            {
                AlertWindow alert =
                    new AlertWindow(
                        "Error",
                        ex.Message, AlertType.Error
                    );

                alert.ShowDialog();
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}