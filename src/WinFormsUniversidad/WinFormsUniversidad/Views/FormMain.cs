using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WinFormsUniversidad.Controllers;
using WinFormsUniversidad.Models;

namespace WinFormsUniversidad.Views
{
    public partial class FormMain : Form
    {
        // =========================
        // 🔹 CONTROLADORES (Capa lógica)
        // =========================
        MateriaController materiaController = new MateriaController();
        ProfesorController profesorController = new ProfesorController();
        EstudianteController estudianteController = new EstudianteController();

        // =========================
        // 🔹 CONSTRUCTOR
        // =========================
        public FormMain()
        {
            InitializeComponent();
        }

        // =========================
        // 🔹 EVENTOS DEL FORMULARIO
        // =========================
        private void FormMain_Load(object sender, EventArgs e)
        {
            btnMateria_Click(sender, e);

            Point position = new Point(400, 200);
            panelMateria.Location = position;
            panelProfesor.Location = position;
            panelEstudiante.Location = position;

            CargarListBoxMaterias();
        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            panelActivo(0);
            CargarListBoxMaterias();
        }

        private void btnProfesor_Click(object sender, EventArgs e)
        {
            panelActivo(1);
            limpiarText(panelProfesor);
            CargarComboMateriasProfesores();
            CargarListBoxProfesores();
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            panelActivo(2);
            limpiarText(panelEstudiante);
            CargarMateriasEstudiante();
            CargarListBoxEstudiantes();
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoMateria.Text) ||
                string.IsNullOrWhiteSpace(txtNombreMateria.Text))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            Materia materia = new Materia(txtCodigoMateria.Text, txtNombreMateria.Text);
            materiaController.AgregarMateria(materia);

            MessageBox.Show("Materia agregada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarListBoxMaterias();
            limpiarText(panelMateria);
            txtCodigoMateria.Focus();
        }

        private void btnAgregarProfesor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdProfesor.Text) ||
                string.IsNullOrWhiteSpace(txtNombreProfesor.Text) ||
                string.IsNullOrWhiteSpace(txtTelefonoProfesor.Text) ||
                comboBoxMateriasProfesor.SelectedItem == null)
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            Materia materia = (Materia)comboBoxMateriasProfesor.SelectedItem;

            Profesor profesor = new Profesor(
                txtIdProfesor.Text,
                txtNombreProfesor.Text,
                txtTelefonoProfesor.Text,
                materia
            );

            profesorController.AgregarProfesor(profesor);

            MessageBox.Show("Profesor agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarListBoxProfesores();
            limpiarText(panelProfesor);
            txtIdProfesor.Focus();
        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdEstudiante.Text) ||
                string.IsNullOrWhiteSpace(txtNombreEstudiante.Text) ||
                string.IsNullOrWhiteSpace(txttelefonoEstudiante.Text))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            List<Materia> materiasSeleccionadas = ObtenerMateriasSeleccionadas();

            if (materiasSeleccionadas.Count == 0)
            {
                MessageBox.Show("Seleccione al menos una materia");
                return;
            }

            Estudiante estudiante = new Estudiante(
                txtIdEstudiante.Text,
                txtNombreEstudiante.Text,
                txttelefonoEstudiante.Text,
                materiasSeleccionadas
            );

            estudianteController.AgregarEstudiante(estudiante);

            MessageBox.Show("Estudiante agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            limpiarText(panelEstudiante);
            limpiarCheckedlistBox();
            CargarListBoxEstudiantes();
            txtIdEstudiante.Focus();
        }

        // =========================
        // 🔹 MÉTODOS DE CARGA (UI)
        // =========================
        private void CargarComboMateriasProfesores()
        {
            List<Materia> listaMaterias = materiaController.ObtenerMaterias();

            comboBoxMateriasProfesor.DataSource = null;
            comboBoxMateriasProfesor.DataSource = listaMaterias;
            comboBoxMateriasProfesor.DisplayMember = "nombre";
            comboBoxMateriasProfesor.ValueMember = "codigo";
        }

        private void CargarMateriasEstudiante()
        {
            checkedListBoxMaterias.DataSource = null;
            checkedListBoxMaterias.DataSource = materiaController.ObtenerMaterias();
            checkedListBoxMaterias.DisplayMember = "nombre";
        }

        private void CargarListBox<T>(ListBox listBox, List<T> data, string display, string value)
        {
            listBox.DataSource = null;
            listBox.DataSource = data;
            listBox.DisplayMember = display;
            listBox.ValueMember = value;
        }

        private void CargarListBoxMaterias()
        {
            CargarListBox(listBoxMaterias, materiaController.ObtenerMaterias(), "nombre", "codigo");
        }

        private void CargarListBoxProfesores()
        {
            CargarListBox(listBoxProfesores, profesorController.ObtenerProfesores(), "nombre", "id");
        }

        private void CargarListBoxEstudiantes()
        {
            CargarListBox(listBoxEstudiantes, estudianteController.ObtenerEstudiantes(), "nombre", "id");
        }

        // =========================
        // 🔹 MÉTODOS AUXILIARES
        // =========================
        private void panelActivo(int i)
        {
            panelMateria.Visible = i == 0;
            panelProfesor.Visible = i == 1;
            panelEstudiante.Visible = i == 2;
        }

        private void limpiarText(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
            }
        }

        private void limpiarCheckedlistBox()
        {
            for (int i = 0; i < checkedListBoxMaterias.Items.Count; i++)
            {
                checkedListBoxMaterias.SetItemChecked(i, false);
            }
        }

        private List<Materia> ObtenerMateriasSeleccionadas()
        {
            List<Materia> lista = new List<Materia>();

            foreach (var item in checkedListBoxMaterias.CheckedItems)
            {
                lista.Add((Materia)item);
            }

            return lista;
        }
    }
}