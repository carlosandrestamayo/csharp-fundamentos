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

namespace WpfAppProyectoIntegrador2026_1.Views.Cotizaciones
{
    /// <summary>
    /// Lógica de interacción para CotizacionesView.xaml
    /// </summary>
    public partial class CotizacionesView : UserControl
    {
        private readonly CotizacionController cotizacionController = new CotizacionController();

        private List<Cotizacion> cotizacionesList = new List<Cotizacion>();
        public CotizacionesView()
        {
            InitializeComponent();
        }

        private void LoadCotizaciones()
        {
            try
            {
                cotizacionesList = cotizacionController.GetAll();

                tableCotizaciones.ItemsSource = null;

                tableCotizaciones.ItemsSource = cotizacionesList;
            }
            catch (Exception ex)
            {
                AlertWindow alert = new AlertWindow("Error", ex.Message, AlertType.Error);
                alert.ShowDialog();
            }
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string texto = txtSearch.Text.ToLower();


            //var filtereds = cotizacionesList
            //    .Where(c =>
            //        c.Nombre.ToLower().Contains(texto)
            //        ||
            //        c.Identificacion.ToLower().Contains(texto)
            //        ||
            //        c.Telefono.ToLower().Contains(texto)
            //        ||
            //        c.Correo.ToLower().Contains(texto)
            //    )
            //    .ToList();

            //tableCotizaciones.ItemsSource = null;

            //tableCotizaciones.ItemsSource = filtereds;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddCotizacionWindow addCotizacionWindow = new AddCotizacionWindow();

            bool? result = addCotizacionWindow.ShowDialog();

            if (result == true)
            {
                LoadCotizaciones();
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
        
        }

        private void CmbEstado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                txtSearch.Clear();

                //tableCotizaciones.ItemsSource = null;

                //tableCotizaciones.ItemsSource = clientesList;
            }
        }


    }
}
