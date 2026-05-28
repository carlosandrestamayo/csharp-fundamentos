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

namespace WpfAppProyectoIntegrador2026_1.Views
{
    /// <summary>
    /// Lógica de interacción para AlertWindow.xaml
    /// </summary>
    public partial class AlertWindow : Window
    {
        public AlertWindow(string titulo, string mensaje)
        {
            InitializeComponent();
            txtTitulo.Text = titulo;
            txtMensaje.Text = mensaje;
        }

        private void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
