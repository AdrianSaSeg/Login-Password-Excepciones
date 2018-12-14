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
    public partial class Form1 : Form
    {
        //variables globales (para toda la clase)
        public int _Intentos { get; set; } = 5;
        public int[] _Numeros { get; set; } = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public int _SumaRandom { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string login = textBox1.Text;
                int pass = int.Parse(textBox2.Text);
                
                FormatException ex = new FormatException("Error, la contraseña solo admite números");

                
                 if (login != "admin" || pass != 1234 || textBox3.Text != Convert.ToString(_SumaRandom))
                 {
                    _Intentos = _Intentos - 1;
                    MessageBox.Show("Usuario o contraseña incorrecta, tiene " + _Intentos + " más");
                    
                    if (_Intentos == 0)
                    {
                        MessageBox.Show("Has agotado el numero de intentos");
                        Close();
                    }
                 }
                 else
                 {
                    MessageBox.Show("Ha entrado correctamente");
                    FormGridView formGridView = new FormGridView("Hola");                    
                    formGridView.ShowDialog();                    
                 }

                
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                _Intentos = _Intentos - 1;
                MessageBox.Show("Error, tienes " + _Intentos + " más");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally //codigo que siempre se ejecuta
            {
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calculaValorAleatorio(_Numeros, label3, label4);
        }

        public void calculaValorAleatorio(int[] arrayInt, Label l1, Label l2)
        {
            // genero un número aleatorio
            Random ran = new Random();

            // guardamos en la variable numRandom un numero aleatorio del array numeros
            int numRandom1 = arrayInt[ran.Next(0, arrayInt.Length)];
            int numRandom2 = arrayInt[ran.Next(0, arrayInt.Length)];
            
            // cambio la propiedad del Label l
            l1.Text = Convert.ToString(numRandom1);
            l2.Text = Convert.ToString(numRandom2);

            //cambio el valor de la propiedad global sumaRandom

            _SumaRandom = numRandom1 + numRandom2;

        }
    }
}
