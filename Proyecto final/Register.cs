using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inicio_de_sesion
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelRegister_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Login cerrar = new Login();
                cerrar.Close();
            }
        }

        private void AcceptRegister_button_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=KARLAGUERRA89; database=Users; integrated security=true");
            string push = "INSERT INTO Usuario(carne_id, usuario, contrasena, pregunta) VALUES (@carne_id,@usuario,@contrasena,@pregunta)SELECT SCOPE_IDENTITY()";
            conexion.Open();
            SqlCommand comando = new SqlCommand(push, conexion);
            comando.Parameters.AddWithValue("@carne_id", CarneRegister_box.Text);
            comando.Parameters.AddWithValue("@usuario", UserReister_box.Text);
            comando.Parameters.AddWithValue("@contrasena", PasswordRegister_box.Text);
            comando.Parameters.AddWithValue("@pregunta", QuestionRegister_box.Text);
            comando.ExecuteNonQuery();
            
        }
    }
}
