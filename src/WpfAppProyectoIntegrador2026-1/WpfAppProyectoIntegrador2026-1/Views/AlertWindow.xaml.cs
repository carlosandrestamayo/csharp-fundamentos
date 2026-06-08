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
        public AlertWindow(string titulo, string mensaje, AlertType type)
        {
            InitializeComponent();
            txtTitulo.Text = titulo;
            txtMensaje.Text = mensaje;
            ConfigureAlert(type);
        }

        private void BtnAcept_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ConfigureAlert(AlertType type)
        {
            switch (type)
            {
                case AlertType.Success:
                    txtIcon.Text = "✓";
                    brdIcon.Background = GetBrush("SuccessColor");
                    btnAccept.Background = GetBrush("SuccessColor");
                    break;

                case AlertType.Error:
                    txtIcon.Text = "✖";
                    brdIcon.Background = GetBrush("DangerColor");
                    btnAccept.Background = GetBrush("DangerColor");
                    break;

                case AlertType.Warning:
                    txtIcon.Text = "⚠";
                    brdIcon.Background = GetBrush("WarningColor");
                    btnAccept.Background = GetBrush("WarningColor");
                    break;

                case AlertType.Info:
                    txtIcon.Text = "ℹ";
                    brdIcon.Background = GetBrush("PrimaryColor");
                    btnAccept.Background = GetBrush("WarningColor");
                    break;
            }
        }

        private Brush GetBrush(string resourceName)
        {
            return (Brush)Application.Current.Resources[resourceName];
        }
    }

    public enum AlertType
    {
        Success,
        Error,
        Warning,
        Info
    }
}
