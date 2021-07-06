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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Login_button_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var username = textBox1.Text;
            var password = textBox2.Text;
            if (textBox1.Text == "") return;
            var db = new project_dbContext();
            var user = db.Employees.FirstOrDefault(u => u.UserEmployee.Equals(username) && u.PasswordEmployee.Equals(password));
            textBox2.Text = "";
            if (user is null)
            {

                MessageBox.Show("Usuario o contrasena incorrecta.", "Ingreso fallido");


                return;
            }
            Cabin cdb = db.Set<Cabin>().SingleOrDefault(u => u.IdManager == user.Id);
            Employee edb = db.Set<Employee>().SingleOrDefault(u => u.Id == user.Id);
            Login newLog = new Login(cdb, edb);

            db.Add(newLog);
            db.SaveChanges();
            Menu menu = new Menu(newLog);
            this.Hide();
            menu.ShowDialog();
            menu.Dispose();
            this.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }

        }

        
    }
}
