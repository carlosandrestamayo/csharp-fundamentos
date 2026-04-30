namespace PedidoAppWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // ==========================================================
            // NOTA IMPORTANTE:
            // ==========================================================
            // Este formulario trabaja bajo el modelo de programación
            // orientada a eventos.
            //
            // Esto significa que el método CalcularTotal NO se ejecuta solo,
            // sino cuando ocurre un evento (por ejemplo: CheckedChanged).
            //
            // Es decir:
            // Usuario interactúa → Se dispara un evento → El programa responde
        }

        // ==========================================================
        // MÉTODO: CalcularTotal
        // ==========================================================
        // Este método se encarga de calcular el valor total del pedido
        // cada vez que el usuario cambia una selección en el formulario.
        //
        // Está pensado para ser reutilizado por múltiples controles:
        // RadioButton y CheckBox.
        //
        // Parámetros:
        // sender → control que generó el evento
        // e      → información adicional del evento

        private void CalcularTotal(object sender, EventArgs e)
        {
            // Inicializamos el total en 0 cada vez que se recalcula.
            // Esto evita acumulaciones incorrectas.
            int total = 0;

            // ======================================================
            // 1. RADIOBUTTON → SELECCIÓN ÚNICA
            // ======================================================
            // Los RadioButton funcionan en grupo:
            // solo uno puede estar seleccionado a la vez.
            //
            // Aquí determinamos el precio base del producto.

            if (radioPequeno.Checked)
                total += 10000; // Precio base tamaño pequeño

            else if (radioMediano.Checked)
                total += 15000; // Precio base tamaño mediano

            else if (radioGrande.Checked)
                total += 20000; // Precio base tamaño grande

            // ⚠️ Nota pedagógica:
            // Usamos "else if" porque solo uno puede estar activo.
            // Esto refuerza la idea de selección exclusiva.


            // ======================================================
            // 2. CHECKBOX → SELECCIÓN MÚLTIPLE
            // ======================================================
            // A diferencia de los RadioButton, los CheckBox permiten
            // seleccionar varias opciones al mismo tiempo.
            //
            // Cada condición se evalúa de forma independiente.

            if (checkQueso.Checked)
                total += 2000; // Se suma si el usuario selecciona queso

            if (checkTocineta.Checked)
                total += 3000; // Se suma si selecciona tocineta

            if (checkPapas.Checked)
                total += 4000; // Se suma si selecciona papas

            // ⚠️ Nota pedagógica:
            // Aquí NO usamos "else if" porque el usuario puede elegir
            // múltiples extras al mismo tiempo.


            // ======================================================
            // 3. RESULTADO EN TIEMPO REAL
            // ======================================================
            // Mostramos el total actualizado en un Label del formulario.
            //
            // Este valor cambia automáticamente cada vez que el usuario
            // interactúa con los controles (sin necesidad de botón).

            labelTotal.Text = "Total: $" + total;

            // 💡 Idea clave:
            // El sistema está reaccionando en tiempo real a las decisiones
            // del usuario, lo que es fundamental en interfaces gráficas.
        }
    }
}