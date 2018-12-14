using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio14_LoginPassExcepciones
{
    public partial class FormNuevoUsuario : Form
    {
        public DataGridView datosTabla { get; set; }
        public FormNuevoUsuario()
        {
            InitializeComponent();
        }

        public FormNuevoUsuario(DataGridView dataGrid)
        {
            InitializeComponent();
            datosTabla = dataGrid;

        }

        public void Limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                datosTabla.Rows.Add(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), textBox4.Text);

                Limpiar();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message + " Introduce un número en la casilla teléfono");               
            }
           
        }
    }
}
