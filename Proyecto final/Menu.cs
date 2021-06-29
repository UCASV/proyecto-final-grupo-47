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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {

        }

        private void proceso_buttom_Click(object sender, EventArgs e)
        {
            Atracking abrir = new Atracking();
            abrir.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Steps abrir = new Steps();
            abrir.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void seguimiento_buttom_Click(object sender, EventArgs e)
        {
            /*Amanegement abrir = new Amanegement();
            abrir.Show();
            this.Close();*/
        }
    }
}
