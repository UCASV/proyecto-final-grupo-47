using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio_de_sesion
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

        }

        private void boxAt_enfermedades_TextChanged(object sender, EventArgs e)
        {
            if (chk_si.Checked || chk_no.Checked)
            {
                BackColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
