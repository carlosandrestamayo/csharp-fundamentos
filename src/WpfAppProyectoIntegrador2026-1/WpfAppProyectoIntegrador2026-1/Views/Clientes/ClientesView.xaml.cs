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
using WpfAppProyectoIntegrador2026_1.Models.Enums;

namespace WpfAppProyectoIntegrador2026_1.Views.Clientes
{
    /// <summary>
    /// Lógica de interacción para ClientesView.xaml
    /// </summary>
    public partial class ClientesView : UserControl
    {
        private readonly ClienteController clienteController = new ClienteController();

        private List<Cliente> clientesList = new List<Cliente>();


        public ClientesView()
        {
            InitializeComponent();

            LoadClientes();

            txtSearch.KeyDown += TxtSearch_KeyDown;
        }

        private void LoadClientes()
        {
            try 
            {   
                clientesList = clienteController.GetAll();

                tableClientes.ItemsSource = null;

                tableClientes.ItemsSource = clientesList;
            }
            catch (Exception ex)
            {
                AlertWindow alert = new AlertWindow("Error",ex.Message, AlertType.Error);
                alert.ShowDialog();
            }
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
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

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                txtSearch.Clear();

                tableClientes.ItemsSource = null;

                tableClientes.ItemsSource = clientesList;
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddClienteWindow addClienteWindow = new AddClienteWindow();

            addClienteWindow.ShowDialog();

            LoadClientes();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Cliente cliente = (sender as Button).DataContext as Cliente;

            if (cliente != null)
            {
                EditClienteWindow editClienteWindow = new EditClienteWindow(cliente);

                editClienteWindow.ShowDialog();

                LoadClientes();
            }
        }

     }
}
