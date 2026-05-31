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
using WpfAppProyectoIntegrador2026_1.Repositorys;
using WpfAppProyectoIntegrador2026_1.Security;
using WpfAppProyectoIntegrador2026_1.Views;
using WpfAppProyectoIntegrador2026_1.Views.Authentication;
using WpfAppProyectoIntegrador2026_1.Views.Clientes;
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

            // Vista inicial
            Contenedor.Content = new DashboardView();

            LoadUserInfo();

            ApplyPermissions();
        }

        private void BtnDashboard_Click(object sender, RoutedEventArgs e)
        {
            Contenedor.Content = new DashboardView();
        }

        private void BtnClientes_Click(object sender, RoutedEventArgs e)
        {
            Contenedor.Content = new ClientesView();
        }

        private void BtnMateriales_Click(object sender, RoutedEventArgs e)
        {
            Contenedor.Content = new MaterialesView();

            MaterialRepository materialRepository = new MaterialRepository();
            //materialRepository.Leer();
        }

        private void BtnCotizaciones_Click(object sender, RoutedEventArgs e)
        {
            Contenedor.Content = new CotizacionesView();
        }

        private void BtnFacturas_Click(object sender, RoutedEventArgs e)
        {
            Contenedor.Content = new FacturasView();
        }

        private void BtnUsuarios_Click(object sender, RoutedEventArgs e)
        {
            Contenedor.Content = new UsuariosView();
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

            if (usuario.Rol != Rol.Administrador)
            {
                btnUsuarios.Visibility = Visibility.Collapsed;
            }
        }

    }
}