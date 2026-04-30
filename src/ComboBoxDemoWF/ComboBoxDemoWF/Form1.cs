using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;

namespace ComboBoxDemoWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // ==========================================================
            // ¿QUÉ HACE ESTE EJERCICIO?
            // ==========================================================
            // Este programa usa un ComboBox como un menú de decisiones.
            // Dependiendo de lo que el usuario seleccione, el sistema
            // ejecuta una acción diferente automáticamente.
            //
            // Es decir:
            // Usuario selecciona → Programa reacciona
            // ==========================================================


            // ==============================
            // 1. CARGA INICIAL DE OPCIONES
            // ==============================
            // Aquí llenamos el ComboBox con opciones que representan
            // acciones que el usuario puede ejecutar.

            comboBoxOpciones.Items.Add("Mostrar cantidad");
            comboBoxOpciones.Items.Add("Mostrar seleccionado");
            comboBoxOpciones.Items.Add("Agregar elemento");
            comboBoxOpciones.Items.Add("Limpiar lista");


            // ==============================
            // 2. EVENTO PRINCIPAL
            // ==============================
            // Este evento se ejecuta automáticamente cuando el usuario
            // cambia la selección en el ComboBox.
            //
            // Aquí ocurre la "magia" del ejercicio.

            comboBoxOpciones.SelectedIndexChanged += comboBoxOpciones_SelectedIndexChanged;
        }

        // ==========================================================
        // 3. LÓGICA DEL PROGRAMA (RESPUESTA DEL SISTEMA)
        // ==========================================================
        // Este método detecta qué opción eligió el usuario y ejecuta
        // una acción diferente en cada caso.

        private void comboBoxOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Guardamos la opción seleccionada por el usuario
            string opcion = comboBoxOpciones.SelectedItem.ToString();


            // ======================================================
            // ESTRUCTURA DE DECISIÓN
            // ======================================================
            // Dependiendo de la opción elegida, el programa hace algo distinto

            switch (opcion)
            {
                case "Mostrar cantidad":
                    // Cuenta cuántos elementos hay en el ComboBox
                    // y muestra ese valor en pantalla
                    labelInfo.Text = "Cantidad: " + comboBoxOpciones.Items.Count;
                    break;

                case "Mostrar seleccionado":
                    // Muestra el texto actualmente seleccionado
                    labelInfo.Text = "Seleccionado: " + comboBoxOpciones.Text;
                    break;

                case "Agregar elemento":
                    // Agrega un nuevo elemento a la lista del ComboBox
                    comboBoxOpciones.Items.Add("Nuevo Item");

                    labelInfo.Text = "Elemento agregado";
                    break;

                case "Limpiar lista":
                    // Elimina todos los elementos del ComboBox
                    comboBoxOpciones.Items.Clear();

                    labelInfo.Text = "Lista vacía";
                    break;
            }
        }

        // ==========================================================
        // 4. BOTÓN DE APOYO
        // ==========================================================
        // Este botón permite reforzar el uso de la propiedad Text,
        // mostrando el valor actual seleccionado en el ComboBox.

        private void buttonAccion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Texto actual: " + comboBoxOpciones.Text);
        }
    }
}
