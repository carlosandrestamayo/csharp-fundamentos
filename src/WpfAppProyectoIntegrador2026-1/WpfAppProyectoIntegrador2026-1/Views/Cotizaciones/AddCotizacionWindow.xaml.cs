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
        private Cliente? clienteSeleccionado;

        private Material? materialSeleccionado;

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
                clienteSeleccionado = searchClienteWindow.SelectedCliente;

                txtClienteNombre.Text = clienteSeleccionado.Nombre;

                txtClienteIdentificacion.Text = clienteSeleccionado.Identificacion;

                txtClienteTelefono.Text = clienteSeleccionado.Telefono;

                txtClienteCorreo.Text = clienteSeleccionado.Correo;

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
