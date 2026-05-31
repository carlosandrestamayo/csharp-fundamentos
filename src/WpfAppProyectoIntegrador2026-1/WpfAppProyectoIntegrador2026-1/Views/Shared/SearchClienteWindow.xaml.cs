using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using WpfAppProyectoIntegrador2026_1.Controllers;
using WpfAppProyectoIntegrador2026_1.Models;

namespace WpfAppProyectoIntegrador2026_1.Views.Shared
{
    public partial class SearchClienteWindow : Window
    {
        private readonly ClienteController clienteController =
            new ClienteController();

        private List<Cliente> clientesList =
            new List<Cliente>();

        public Cliente? SelectedCliente
        {
            get;
            private set;
        }

        public SearchClienteWindow()
        {
            InitializeComponent();

            LoadClientes();

            txtSearch.KeyDown += TxtSearch_KeyDown;

            tableClientes.MouseDoubleClick += TableClientes_MouseDoubleClick;

        }

        private void LoadClientes()
        {
            clientesList = clienteController.GetAll();

            tableClientes.ItemsSource = null;

            tableClientes.ItemsSource = clientesList;
        }

        private void TxtSearch_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            string texto = txtSearch.Text.ToLower();

            var filtereds = clientesList
                .Where(c =>
                    c.Nombre.ToLower().Contains(texto)
                    ||
                    c.Identificacion.ToLower().Contains(texto)
                    ||
                    c.Telefono.ToLower().Contains(texto)
                    ||
                    c.Correo.ToLower().Contains(texto)
                )
                .ToList();

            tableClientes.ItemsSource = null;

            tableClientes.ItemsSource = filtereds;
        }

        private void TxtSearch_KeyDown(
            object sender,
            KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                txtSearch.Clear();

                tableClientes.ItemsSource = null;

                tableClientes.ItemsSource = clientesList;
            }
        }

        private void TableClientes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Cliente? cliente = tableClientes.SelectedItem as Cliente;

            if (cliente == null)
            {
                return;
            }

            SelectedCliente = cliente;

            DialogResult = true;

            Close();
        }

        private void BtnSelect_Click(object sender, RoutedEventArgs e)
        {
            Cliente? cliente = tableClientes.SelectedItem as Cliente;


            if (cliente == null)
            {
                AlertWindow alert =
                    new AlertWindow(
                        "Información",
                        "Seleccione un cliente."
                    );

                alert.ShowDialog();

                return;
            }

            SelectedCliente = cliente;

            DialogResult = true;

            Close();
        }

        private void BtnCancel_Click(
            object sender,
            RoutedEventArgs e)
        {
            DialogResult = false;

            Close();
        }
    }
}