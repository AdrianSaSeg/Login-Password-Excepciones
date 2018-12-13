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

            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] filaNueva = new string[4] { "Nombre", "Apellido", "Teléfono", "Email" };

            datosTabla.Rows.Add(filaNueva);
        }
    }
}
