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
            //dataGridView1 es el nombre del datagrid que hemos creado (en el diseño)
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
            //obtener el registro a eliminar
            int filaSelect = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            
            /*
            
            //eliminar el registro seleccionado
            if (filaSelect > 0)
            {
                for (int i = 0; i < filaSelect; i++)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }*/

            //***OTRA FORMA
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro de eliminar los usuarios seleccionados?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                //eliminar el registro seleccionado
                foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(i);
                }
            }

            //mostrar un mensaje para avisar de la eliminacion

            if (filaSelect > 1)
            {
                MessageBox.Show("Ha eliminado las filas seleccionadas");
            }
            else
            {
                MessageBox.Show("Ha eliminado la fila seleccionada");
            }
        }

    }
}
