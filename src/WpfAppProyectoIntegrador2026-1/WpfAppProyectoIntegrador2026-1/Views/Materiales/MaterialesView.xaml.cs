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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppProyectoIntegrador2026_1.Controllers;
using WpfAppProyectoIntegrador2026_1.Models;


namespace WpfAppProyectoIntegrador2026_1.Views
{
    /// <summary>
    /// Lógica de interacción para MaterialesView.xaml
    /// </summary>
    public partial class MaterialesView : UserControl
    {
        MaterialController materialController = new MaterialController();
        private List<Models.Material> listaMateriales = new List<Models.Material>();

       
        public MaterialesView()
        {
            InitializeComponent();

            CargarMateriales();
        }

        private void CargarMateriales()
        {
            listaMateriales = materialController.ObtenerMateriales();

            tablaMateriales.ItemsSource = null;

            tablaMateriales.ItemsSource = listaMateriales;
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TxtBuscar_TextChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
