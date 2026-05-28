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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppProyectoIntegrador2026_1.Controllers;
using WpfAppProyectoIntegrador2026_1.Models;

namespace WpfAppProyectoIntegrador2026_1.Views
{
    /// <summary>
    /// Lógica de interacción para CotizacionesView.xaml
    /// </summary>
    public partial class CotizacionesView : UserControl
    {
        private readonly ClienteController clienteController = new ClienteController();

        private  List<Cliente> clientes = new List<Cliente>();

        public CotizacionesView()
        {
            InitializeComponent();
            LoadClientes();
        }

        private void LoadClientes()
        {
            clientes = clienteController.GetAll();

            cbClientes.ItemsSource = clientes;

            cbClientes.DisplayMemberPath = "Nombre";
        }
        private void CbClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cliente cliente = cbClientes.SelectedItem as Cliente;


            if (cliente != null)
            {
                txtIdentificacion.Text =
                    cliente.Identificacion;

                txtTelefono.Text =
                    cliente.Telefono;

                txtCorreo.Text =
                    cliente.Correo;
            }
        }
    }
}
