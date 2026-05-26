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
using WpfAppProyectoIntegrador2026_1.Views.Materiales;
using Material = WpfAppProyectoIntegrador2026_1.Models.Material;


namespace WpfAppProyectoIntegrador2026_1.Views
{
    /// <summary>
    /// Lógica de interacción para MaterialesView.xaml
    /// </summary>
    public partial class MaterialesView : UserControl
    {
        MaterialController materialController = new MaterialController();
        
        private List<Models.Material> materialesList = new List<Models.Material>();

       
        public MaterialesView()
        {
            InitializeComponent();

            LoadMateriales();

            txtSearch.KeyDown += TxtSearch_KeyDown;
        }

        
        private void LoadMateriales()
        {
            materialesList = materialController.GetAll();

            tableMateriales.ItemsSource = null;

            tableMateriales.ItemsSource = materialesList;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddMaterialWindow addMaterialWindow = new AddMaterialWindow();

            addMaterialWindow.ShowDialog();

            LoadMateriales();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Material material = (sender as Button).DataContext as Material;

            if (material != null)
            {
                EditMaterialWindow editMaterialWindow = new EditMaterialWindow(material);

                editMaterialWindow.ShowDialog();

                LoadMateriales();
            }
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string texto = txtSearch.Text.ToLower();


            var filtereds = materialesList
                .Where(m =>
                    m.Nombre.ToLower().Contains(texto)
                    ||
                    m.Descripcion.ToLower().Contains(texto)
                )
                .ToList();

            tableMateriales.ItemsSource = null;

            tableMateriales.ItemsSource = filtereds;
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                txtSearch.Clear();

                tableMateriales.ItemsSource = null;

                tableMateriales.ItemsSource = materialesList;
            }
        }
    }
}
