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
        //variable para toda la clase
        public int intentos { get; set; } = 5;

        public int[] numeros { get; set; } = { 1, 2, 3, 4, 5, 6, 7, 8 };
        public int numRandom { get; set; }
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

                
                 if (login != "admin" || pass != 1234 || textBox3.Text != label3.Text)
                 {
                    intentos = intentos - 1;
                    MessageBox.Show("Usuario o contraseña incorrecta, tiene " + intentos + " más");
                    
                    if (intentos == 0)
                    {
                        MessageBox.Show("Has agotado el numero de intentos");
                        Close();
                    }
                 }
                 else
                 {
                    MessageBox.Show("Ha entrado correctamente");
                    Close();
                 }                               
                                            
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                intentos = intentos - 1;
                MessageBox.Show("Error, tienes " + intentos + " más");
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
            calculaValorAleatorio(numeros, label3);
        }

        public void calculaValorAleatorio(int[] arrayInt, Label l)
        {
            // genero un número aleatorio
            Random ran = new Random();

            // guardamos en la variable numRandom un numero aleatorio del array numeros
            int numRandom = arrayInt[ran.Next(0, arrayInt.Length)];

            // cambio la propiedad del Label l
            l.Text = Convert.ToString(numRandom);

        }
    }
}
