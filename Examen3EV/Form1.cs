using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen3EV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Diccionario diccionario= new Diccionario();
            int resultado = diccionario.Analizar(txtFrase1.Text, txtFrase2.Text);
            if (resultado == 0)
            {
                for (int i = 0; i < diccionario.palabras.Count; i++)
                    txtDiccionario.Text += diccionario.palabras[i] + Environment.NewLine;
            }
            else if (resultado == -1)
                MessageBox.Show("La frase 1 no es correcta");
            else if (resultado == -2)
                MessageBox.Show("La frase 2 no es correcta");
        }
    }
}
