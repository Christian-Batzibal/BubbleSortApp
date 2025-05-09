using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BubbleSortApp
{
    public partial class Form1 : Form
    {
        public List<int> numeros = new List<int>();
        public int cantidadNumeros;

        public Form1()
        {
            InitializeComponent();
        }

        public void btnEstablecerCantidad_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantidad.Text, out cantidadNumeros) && cantidadNumeros >= 1 && cantidadNumeros <= 10)
            {
                lblEstado.Text = $"Ingresa el primer número (de 1 a {cantidadNumeros}):";
                txtEntrada.Enabled = true;
                btnIngresar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número entre 1 y 10.");
            }
        }

        public void txtEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && numeros.Count < cantidadNumeros)
            {
                if (int.TryParse(txtEntrada.Text, out int num))
                {
                    numeros.Add(num);
                    txtEntrada.Clear();
                    txtEntrada.Focus();

                    if (numeros.Count == cantidadNumeros)
                    {
                        btnIngresar.Enabled = false;
                        btnOrdenar.Enabled = true;
                        lblEstado.Text = "Ahora puedes ordenar los números.";
                        MostrarNumeros();
                    }
                    else
                    {
                        lblEstado.Text = $"Ingresa el número {numeros.Count + 1}:";
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido.");
                }
            }
        }

        public void btnIngresar_Click(object sender, EventArgs e)
        {
            if (numeros.Count < cantidadNumeros)
            {
                if (int.TryParse(txtEntrada.Text, out int num))
                {
                    numeros.Add(num);
                    txtEntrada.Clear();
                    txtEntrada.Focus();

                    if (numeros.Count == cantidadNumeros)
                    {
                        btnIngresar.Enabled = false;
                        btnOrdenar.Enabled = true;
                        lblEstado.Text = "Ahora puedes ordenar los números.";
                        MostrarNumeros();
                    }
                    else
                    {
                        lblEstado.Text = $"Ingresa el número {numeros.Count + 1}:";
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido.");
                }
            }
        }

        public void MostrarNumeros()
        {
            txtOriginal.Text = string.Join(", ", numeros);
        }

        public void btnOrdenar_Click(object sender, EventArgs e)
        {
            panelAscendente.Controls.Clear();
            panelDescendente.Controls.Clear();

            var numerosAscendente = BubbleSort(new List<int>(numeros), ascending: true);
            var numerosDescendente = BubbleSort(new List<int>(numeros), ascending: false);

            DisplayInPanel(numerosAscendente, panelAscendente);
            DisplayInPanel(numerosDescendente, panelDescendente);
        }

        public List<int> BubbleSort(List<int> lista, bool ascending)
        {
            int n = lista.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    bool condition = ascending ? lista[j] > lista[j + 1] : lista[j] < lista[j + 1];

                    if (condition)
                    {
                        int temp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temp;
                    }
                }
            }
            return lista;
        }

        public void DisplayInPanel(List<int> numerosOrdenados, Panel panel)
        {
            int x = 10;
            int y = 10;

            foreach (var numero in numerosOrdenados)
            {
                TextBox txtNumero = new TextBox
                {
                    Text = numero.ToString(),
                    Width = 50,
                    Height = 50,
                    Location = new System.Drawing.Point(x, y),
                    TextAlign = HorizontalAlignment.Center,
                    Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold),
                    BackColor = System.Drawing.Color.DarkRed,
                    ForeColor = System.Drawing.Color.White,
                    BorderStyle = BorderStyle.FixedSingle
                };

                panel.Controls.Add(txtNumero);

                x += 60;
            }
        }

        public void btnReiniciar_Click(object sender, EventArgs e)
        {
            numeros.Clear();
            txtCantidad.Clear();
            txtEntrada.Clear();
            txtOriginal.Clear();
            panelAscendente.Controls.Clear();
            panelDescendente.Controls.Clear();

            lblEstado.Text = "Ingrese la cantidad de numeros que quiere hacer en esta consulta (1 a 10):";
            txtCantidad.Focus();
            btnEstablecerCantidad.Enabled = true;
            btnIngresar.Enabled = false;
            btnOrdenar.Enabled = false;
        }

        public void lblEstado_Click(object sender, EventArgs e)
        {
        }

        public void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
