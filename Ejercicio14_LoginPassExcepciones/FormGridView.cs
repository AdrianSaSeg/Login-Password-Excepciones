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
    public partial class FormGridView : Form
    {
        
        public FormGridView(string texto)
        {
            InitializeComponent();
            label1.Text = texto;
        }

        private void RellenarFilas()
        {
            //creamos un array para rellenar la primera fila de datos
            string[] row0 = { "Pepe", "Martínez", "999", "pepe@email.com" };
            //dataGridView1 es el nombre del datagrid que hemos creado
            dataGridView1.Rows.Add(row0);

        }

        private void FormGridView_Load(object sender, EventArgs e)
        {
            RellenarFilas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNuevoUsuario formNuevoUsuario = new FormNuevoUsuario(dataGridView1);
            formNuevoUsuario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
