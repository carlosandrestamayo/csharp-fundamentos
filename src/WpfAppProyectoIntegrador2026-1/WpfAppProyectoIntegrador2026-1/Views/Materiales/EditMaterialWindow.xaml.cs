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
    /// Lógica de interacción para EditMaterialWindow.xaml
    /// </summary>
    public partial class EditMaterialWindow : Window
    {
        private readonly MaterialController materialController = new MaterialController();

        private readonly Material material;

        public EditMaterialWindow(Material material)
        {
            InitializeComponent();
            
            this.material = material;

            LoadMaterialData();

            txtNombre.KeyDown += TextBox_KeyDown;
            txtPrecioUnidad.KeyDown += TextBox_KeyDown;
            txtDescripcion.KeyDown += TextBox_KeyDown;    

        }

        private void LoadMaterialData()
        {
            txtNombre.Text = material.Nombre;

            txtPrecioUnidad.Text = material.PrecioUnidad.ToString();

            txtDescripcion.Text = material.Descripcion;

            chkActivo.IsChecked = material.Activo;

        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Material updatedMaterial = new Material(material.Id, txtNombre.Text,Decimal.Parse(txtPrecioUnidad.Text), txtDescripcion.Text, chkActivo.IsChecked ?? false);

            string message = materialController.Update(updatedMaterial);

            MessageBox.Show(message);

            if (message == "Material updated successfully.")
            {
                Close();
            }

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
