using System;
using System.Windows.Forms;
namespace Tipos_de_error {
    public partial class FormPrincipal : Form {
        /// <summary>
        /// Objeto tipo TiposDeError, declarado
        /// Utilizado para obtener todos los cálculos pertinentes de los tipos de errores
        /// </summary>
        TiposDeError tiposDeErrores;
        /// <summary>
        /// Constructor del Form
        /// </summary>
        public FormPrincipal() {
            InitializeComponent();
        }
        /// <summary>
        /// Forza al Garbage Collector a trabajar para eliminar totalmente el objeto de la memoria
        /// </summary>
        private void ForzarGC() => tiposDeErrores = null;
        /// <summary>
        /// Limpia los dos campos donde se introducen los números
        /// </summary>
        private void LimpiarCampos() {
            txtValorVerdadero.Clear(); //Limpia el campo de valor verdadero
            txtValorAproximado.Clear(); //Limpia el campo de valor aproximado
        }
        /// <summary>
        /// Calcula todos los tipos de errores y los despliega en un MessageBox
        /// </summary>
        /// <param name="sender">Objeto mensajero</param>
        /// <param name="e">Objeto de eventos</param>
        private void btnTodasLasOperaciones_Click(object sender, EventArgs e) {
            //Intenta crear el objeto, de lo contrario, el unico error posible es un
            //Incorrect Format Input
            try {
                //Asigna los 2 valores (verdadero y aproximado) a la instancia
                tiposDeErrores = new TiposDeError(double.Parse(txtValorAproximado.Text),
                    double.Parse(txtValorVerdadero.Text));
            } catch (Exception ex) {
                //Avisa al usuario en caso de error
                MessageBox.Show($"Ocurrió un error inesperado\n{ex.Message}\nPuede ser debido a que capturó un valor" +
                    $" no numérico",
                    "Error al capturar datos", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                //Aborta el seguimiento del método
                return;
            }
            //Muestra los errores respectivamente
            MessageBox.Show($"Error absoluto: {tiposDeErrores.CalcularErrorAbsoluto()}" +
                $"\nError relativo: {tiposDeErrores.CalcularErrorRelativo()}\n" +
                $"Error relativo porcentual: {tiposDeErrores.CalcularErrorRelativoPorcentual()} %",
                "Cálculo de tipos de errores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Preguntale al usuario si necesita seguir calculando más errores
            //Acá se hace la pregunta del diagrama de flujo en donde el ciclo se cumple en caso
            //de que la respuesta sea 'Y'
            if (!(MessageBox.Show("¿Desea continuar calculando más errores?", "Continuar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                Application.Exit();
            else txtValorVerdadero.Focus(); //Focus en el campo del valor verdadero
            ForzarGC();
            LimpiarCampos();
        }
        /// <summary>
        /// Eventos para que el usuario NO pueda escribir letras, solo números
        /// y hasta 1 punto para números decimales.
        /// </summary>
        /// <param name="sender">Objeto mensajero</param>
        /// <param name="e">Objeto del evento</param>
        /// </ignore>
        private void txtValorVerdadero_KeyPress(object sender, KeyPressEventArgs e) {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)) {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 46) {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }
        private void txtValorAproximado_KeyPress(object sender, KeyPressEventArgs e) {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)) {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 46) {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }
    }
}
