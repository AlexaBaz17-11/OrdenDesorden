using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OrdenDesorden
{
    public partial class Arrays : Form
    {
        private string[] elementos; // Array unidimensional de tipo string

        public Arrays()
        {
            InitializeComponent();
            elementos = new string[0]; // Inicializar el array vacío
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string nuevoElemento = textBoxAgregarPalabra.Text.Trim(); // Obtener el elemento ingresado

            if (!string.IsNullOrEmpty(nuevoElemento))
            {
                Array.Resize(ref elementos, elementos.Length + 1); // Aumentar el tamaño del array en 1
                elementos[elementos.Length - 1] = nuevoElemento; // Agregar el nuevo elemento al final del array
                listBoxPalabrasRegistradas.Items.Add(nuevoElemento); // Mostrar el elemento en el ListBox
                textBoxAgregarPalabra.Clear(); // Limpiar el TextBox
            }
            else
            {
                MessageBox.Show("Ingrese un elemento válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDesordenar_Click(object sender, EventArgs e)
        {
            string palabraSeleccionada = listBoxPalabrasRegistradas.SelectedItem?.ToString(); // Obtener la palabra seleccionada del ListBox

            if (string.IsNullOrEmpty(palabraSeleccionada))
            {
                MessageBox.Show("Seleccione una palabra del ListBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string palabraDesordenada = DesordenarPalabra(palabraSeleccionada);
            textBoxPalabraIngresada.Text = palabraDesordenada; // Mostrar la palabra desordenada en el TextBox
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            string palabraSeleccionada = listBoxPalabrasRegistradas.SelectedItem?.ToString(); // Obtener la palabra seleccionada del ListBox

            if (string.IsNullOrEmpty(palabraSeleccionada))
            {
                MessageBox.Show("Seleccione una palabra del ListBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string palabraOrdenada = OrdenarAscendenteRecursivo(palabraSeleccionada);
            textBoxPalabraIngresada.Text = palabraOrdenada; // Mostrar la palabra ordenada en el TextBox
        }

        private string OrdenarAscendenteRecursivo(string palabra)
        {
            if (palabra.Length <= 1)
            {
                return palabra; // Caso base: la palabra ya está ordenada
            }

            char primerCaracter = palabra[0];
            string restoPalabra = palabra.Substring(1);
            string palabraOrdenada = OrdenarAscendenteRecursivo(restoPalabra);

            return InsertarCaracterEnOrden(primerCaracter, palabraOrdenada);
        }

        private string InsertarCaracterEnOrden(char caracter, string palabra)
        {
            if (string.IsNullOrEmpty(palabra) || caracter <= palabra[0])
            {
                return caracter + palabra;
            }

            return palabra[0] + InsertarCaracterEnOrden(caracter, palabra.Substring(1));
        }

        private string DesordenarPalabra(string palabra)
        {
            char[] caracteres = palabra.ToCharArray(); // Convertir la palabra en un array de caracteres
            caracteres = caracteres.OrderBy(c => Guid.NewGuid()).ToArray(); // Desordenar los caracteres
            return new string(caracteres);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}