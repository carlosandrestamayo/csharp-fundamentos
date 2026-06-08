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

        private void BtnAddMaterial_Click(object sender, RoutedEventArgs e)
        {

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
