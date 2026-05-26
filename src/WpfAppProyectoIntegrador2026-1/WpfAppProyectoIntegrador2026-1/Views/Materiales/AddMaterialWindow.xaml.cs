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
using WpfAppProyectoIntegrador2026_1.Controllers;
using WpfAppProyectoIntegrador2026_1.Models;

namespace WpfAppProyectoIntegrador2026_1.Views.Materiales
{
    /// <summary>
    /// Lógica de interacción para AddMaterialWindow.xaml
    /// </summary>
    public partial class AddMaterialWindow : Window
    {
        MaterialController materialController = new MaterialController();
        public AddMaterialWindow()
        {
            InitializeComponent();
            txtNombre.Focus();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            Material material = new Material(Guid.NewGuid(), txtNombre.Text, decimal.Parse(txtPrecioUnidad.Text), txtDescripcion.Text);

            //string message = materialController.Add(material);

            //MessageBox.Show(message);

            //if (message == "Cliente added successfully.")
            //{
            //    Close();
            //}

            Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                TextBox textBox = sender as TextBox;

                if (textBox != null)
                {
                    textBox.Clear();
                }
            }
        }
    }
}
