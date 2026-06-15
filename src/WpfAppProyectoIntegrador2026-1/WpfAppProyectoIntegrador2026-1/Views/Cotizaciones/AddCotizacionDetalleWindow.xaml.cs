using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfAppProyectoIntegrador2026_1.Models;
using WpfAppProyectoIntegrador2026_1.Services;

namespace WpfAppProyectoIntegrador2026_1.Views.Cotizaciones
{
    /// <summary>
    /// Lógica de interacción para AddCotizacionDetalleWindow.xaml
    /// </summary>
    public partial class AddCotizacionDetalleWindow : Window
    {

        private List<Coordenada> coordenadasList = new();
        public CotizacionDetalle? SelectedDetail
        {
            get;
            private set;
        }

        public AddCotizacionDetalleWindow(CotizacionDetalle? selectedDetail)
        {
            SelectedDetail = selectedDetail;
        }

        public AddCotizacionDetalleWindow()
        {
            InitializeComponent();
        }
        
        private void BtnSearchTerrain_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //openFileDialog.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";

            openFileDialog.Filter = "Todos los archivos (*.*)|*.*";



            if (openFileDialog.ShowDialog() != true)
            {
                return;
            }

            string json = File.ReadAllText(openFileDialog.FileName);


            TerrainFile terrainFile = JsonSerializer.Deserialize<TerrainFile>(json)!;


            decimal volumen = VolumeCalculator.Calculate(terrainFile.Coordenadas);

            coordenadasList = terrainFile.Coordenadas;


            txtTerrenoNombre.Text = terrainFile.Nombre;
            
            txtTerrenoDescripcion.Text = terrainFile.Descripcion;

            txtVolumenUnitario.Text = volumen.ToString("N2");
        
        }
        private void BtnSearchMaterial_Click(object sender, RoutedEventArgs e)
        {

        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

        }
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void TxtCantidad_TextChanged(object sender, TextChangedEventArgs e) { 
        
        }

    }
}
