using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class Atracking : Form
    {
        public Atracking()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_si.Checked)
            {
                boxAt_enfermedades.Enabled = true;
                return;
            }
            boxAt_enfermedades.Enabled = false;
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (boxAt_nombres.Text == "" || boxAt_edad.Text == "" || boxAt_dui.Text == "" || boxAt_direccion.Text == "" || boxAt_telefono.Text == "")
            {
                MessageBox.Show("Uno o mas atributos requeridos estan vacios.");
                return;
            }

            uint age = 0;
            try
            {
                age = UInt32.Parse(boxAt_edad.Text);
            }
            catch
            {
                MessageBox.Show("Edad debe ser un numero entero positivo.");
                return;
            }

            if (boxAt_dui.Text.Length != 9)
            {
                MessageBox.Show("El DUI debe ser 9 digitos largo.");
                return;
            }
            uint dui = 0;
            try
            {
                dui = UInt32.Parse(boxAt_dui.Text);
            }
            catch
            {
                MessageBox.Show("El DUI debe contener solamente numeros.");
                return;
            }

            uint phone = 0;
            try
            {
                phone = UInt32.Parse(boxAt_telefono.Text);
            }
            catch
            {
                MessageBox.Show("El telefono debe contener solamente numeros.");
                return;
            }

            if (!(age >= 60 || (age >= 18 && chk_si.Checked) ))
            {
                MessageBox.Show("El paciente no pertence a un grupo de prioridad.");
                return;
            }

            MessageBox.Show("El paciente ha sido ingresado con exito!");
            Approved abrir = new Approved();
            abrir.Show();

        }

        private void Atracking_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu abrir = new Menu();
            abrir.Show();
            this.Close();

        }
    }
}