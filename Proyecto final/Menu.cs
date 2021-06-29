using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_final.Models;

namespace Proyecto_final
{
    public partial class Menu : Form
    {
        Login currentLogin;
        public Menu(Login c)
        {
            currentLogin = c;
            InitializeComponent();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            label6.Text = currentLogin.IdEmployeeNavigation.NameEmployee;
        }

        private void proceso_buttom_Click(object sender, EventArgs e)
        {
            Atracking abrir = new Atracking(currentLogin);
            this.Hide();
            abrir.ShowDialog();
            abrir.Dispose();
            this.Show();
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
            CiteFollowing abrir = new CiteFollowing();
            this.Hide();
            abrir.ShowDialog();
            abrir.Dispose();
            this.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesion?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
