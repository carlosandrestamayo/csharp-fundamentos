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

namespace WpfAppProyectoIntegrador2026_1.Views
{
    /// <summary>
    /// Lógica de interacción para DashboardView.xaml
    /// </summary>
    public partial class DashboardView : UserControl
    {
        private ClienteController clienteController = new ClienteController();
        private MaterialController materialController = new MaterialController();
        
        public DashboardView()
        {
            InitializeComponent();

            txtTotalClientes.Text = clienteController.GetAll().Count.ToString();

            txtTotalMateriales.Text = materialController.GetAll().Count.ToString();
        }
    }
}
