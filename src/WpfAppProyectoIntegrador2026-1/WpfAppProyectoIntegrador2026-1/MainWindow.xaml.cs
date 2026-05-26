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
using WpfAppProyectoIntegrador2026_1.Repositorys;
using WpfAppProyectoIntegrador2026_1.Views;
using WpfAppProyectoIntegrador2026_1.Views.Clientes;

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
    }
}