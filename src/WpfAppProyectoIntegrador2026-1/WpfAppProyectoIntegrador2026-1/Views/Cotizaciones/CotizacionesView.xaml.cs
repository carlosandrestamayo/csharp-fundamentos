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

        private void LoadClientes()
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
    }
}
