using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppProyectoIntegrador2026_1.Models;
using WpfAppProyectoIntegrador2026_1.Models.Enums;
using WpfAppProyectoIntegrador2026_1.Repositorys;
using WpfAppProyectoIntegrador2026_1.Security;
using WpfAppProyectoIntegrador2026_1.Views;
using WpfAppProyectoIntegrador2026_1.Views.Authentication;
using WpfAppProyectoIntegrador2026_1.Views.Clientes;
using WpfAppProyectoIntegrador2026_1.Views.Cotizaciones;
using WpfAppProyectoIntegrador2026_1.Views.Usuarios;

namespace WpfAppProyectoIntegrador2026_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Contenedor.Content = new DashboardView();

            LoadUserInfo();

            ApplyPermissions();

        }

        private void BtnDashboard_Click(object sender, RoutedEventArgs e)
        {
            ActivateMenuButton(btnDashboard);
            Contenedor.Content = new DashboardView();
        }

        private void BtnClientes_Click(object sender, RoutedEventArgs e)
        {
            ActivateMenuButton(btnClientes);
            Contenedor.Content = new ClientesView();
        }

        private void BtnMateriales_Click(object sender, RoutedEventArgs e)
        {
            ActivateMenuButton(btnMateriales);
            Contenedor.Content = new MaterialesView();

            //MaterialRepository materialRepository = new MaterialRepository();
            //materialRepository.Leer();
        }

        private void BtnCotizaciones_Click(object sender, RoutedEventArgs e)
        {
            ActivateMenuButton(btnCotizaciones);
            Contenedor.Content = new CotizacionesView();
        }

        private void BtnFacturas_Click(object sender, RoutedEventArgs e)
        {
            ActivateMenuButton(btnFacturas);
            Contenedor.Content = new FacturasView();
        }

        private void BtnUsuarios_Click(object sender, RoutedEventArgs e)
        {
            ActivateMenuButton(btnUsuarios);
            Contenedor.Content = new UsuariosView();
        }

        private void BtnChangePassword_Click(object sender, RoutedEventArgs e)
        {
            ActivateMenuButton(btnChangePassword);
            ChangeMyPasswordWindow changeMyPasswordWindow = new ChangeMyPasswordWindow();
            changeMyPasswordWindow.ShowDialog();
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            SessionManager.CurrentUser = null;

            LoginWindow loginWindow = new LoginWindow();

            loginWindow.Show();

            Close();
        }

        private void LoadUserInfo()
        {
            Usuario? usuario = SessionManager.CurrentUser;

            if (usuario == null)
            {
                return;
            }

            txtUserName.Text = usuario.Nombre;

            txtUserRole.Text = usuario.Rol.ToString();
        }

        private void ApplyPermissions()
        {
            Usuario? usuario = SessionManager.CurrentUser;

            if (usuario == null)
            {
                return;
            }

            if (usuario.Rol != RolUsuario.Administrador)
            {
                btnUsuarios.Visibility = Visibility.Collapsed;
            }

            if (usuario.Rol != RolUsuario.Operador)
            {
                btnChangePassword.Visibility = Visibility.Collapsed;
            }
        }

        private void ActivateMenuButton(Button activeButton)
        {
            Brush sidebarColor =
                (Brush)Application.Current.Resources["SidebarBackground"];

            Brush primaryColor =
                (Brush)Application.Current.Resources["PrimaryColor"];

            foreach (var control in LogicalTreeHelper.GetChildren(this))
            {
                // No sirve para recorrer profundamente
            }

            Button[] buttons =
            {
                btnDashboard,
                btnClientes,
                btnMateriales,
                btnCotizaciones,
                btnFacturas,
                btnUsuarios,
                btnChangePassword
            };

            foreach (Button button in buttons)
            {
                button.Background = sidebarColor;
            }

            activeButton.Background = primaryColor;
        }
    }
}