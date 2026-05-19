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

namespace WpfAppProyectoIntegrador2026_1.Views.Clientes
{
    /// <summary>
    /// Lógica de interacción para EditarClienteWindow.xaml
    /// </summary>
    public partial class EditClienteWindow : Window
    {
        private Cliente cliente { get; set; }
        
        public EditClienteWindow(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }
        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("BtnGuardar_Click");
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("BtnCancelar_Click");
        }
    }
}
