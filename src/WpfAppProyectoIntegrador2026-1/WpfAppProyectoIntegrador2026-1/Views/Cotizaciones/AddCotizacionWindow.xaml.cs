using System.Windows;
using WpfAppProyectoIntegrador2026_1.Models;
using WpfAppProyectoIntegrador2026_1.Views.Shared;

namespace WpfAppProyectoIntegrador2026_1.Views.Cotizaciones
{
    /// <summary>
    /// Lógica de interacción para AddCotizacionWindow.xaml
    /// </summary>
    public partial class AddCotizacionWindow : Window
    {
        private Cliente? clienteSelected; 

        private Material? materialSelected;

        public AddCotizacionWindow()
        {
            InitializeComponent();
        }

        private void BtnSearchClient_Click(object sender, RoutedEventArgs e)
        {
            SearchClienteWindow searchClienteWindow = new SearchClienteWindow();

            bool? result = searchClienteWindow.ShowDialog();

            if (result == true)
            {
                clienteSelected = searchClienteWindow.SelectedCliente;

                txtClienteNombre.Text = clienteSelected.Nombre;

                txtClienteIdentificacion.Text = clienteSelected.Identificacion;

                txtClienteTelefono.Text = clienteSelected.Telefono;

                txtClienteCorreo.Text = clienteSelected.Correo;

            }

        }

        private void BtnAddItem_Click(object sender, RoutedEventArgs e)
        {
            AddCotizacionDetalleWindow addCotizacionDetalleWindow = new AddCotizacionDetalleWindow();

            addCotizacionDetalleWindow.ShowDialog();
            //SearchMaterialWindow searchMaterialWindow = new SearchMaterialWindow();

            //bool? result = searchMaterialWindow.ShowDialog();

            //if (result == true)
            //{

            //}

        }
        private void BtnDeleteDetail_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
