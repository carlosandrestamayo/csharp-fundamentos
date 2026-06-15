using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfAppProyectoIntegrador2026_1.Controllers;
using WpfAppProyectoIntegrador2026_1.Models;
using WpfAppProyectoIntegrador2026_1.Models.Enums;

namespace WpfAppProyectoIntegrador2026_1.Views.Shared
{
    public partial class SearchMaterialWindow : Window
    {
        private readonly MaterialController materialController = new MaterialController();

        private List<Material> materialesList = new List<Material>();
        public Material? SelectedMaterial
        {
            get;
            private set;
        }

        public SearchMaterialWindow()
        {
            InitializeComponent();

            LoadMateriales();

            txtSearch.KeyDown += TxtSearch_KeyDown;

            tableMateriales.MouseDoubleClick += TableMateriales_MouseDoubleClick;
        }

        private void LoadMateriales()
        {
            materialesList = materialController.GetAll();

            tableMateriales.ItemsSource = null;

            tableMateriales.ItemsSource = materialesList;
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string texto = txtSearch.Text.ToLower();

            var filtereds = materialesList
                .Where(m =>
                    m.Nombre.ToLower().Contains(texto)
                    ||
                    m.Descripcion.ToLower().Contains(texto)
                    ||
                    m.Estado.ToLower().Contains(texto)
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

        private void TableMateriales_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Material? material = tableMateriales.SelectedItem as Material;

            if (material == null)
            {
                return;
            }

            SelectedMaterial = material;

            DialogResult = true;

            Close();
        }

        private void BtnSelect_Click(object sender, RoutedEventArgs e)
        {
            Material? material = tableMateriales.SelectedItem as Material;


            if (material == null)
            {
                AlertWindow alertWindow =
                    new AlertWindow(
                        "Información",
                        "Seleccione un material.",
                        AlertType.Info);

                alertWindow.ShowDialog();

                return;
            }

            SelectedMaterial = material;

            DialogResult = true;

            Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;

            Close();
        }
    }
}