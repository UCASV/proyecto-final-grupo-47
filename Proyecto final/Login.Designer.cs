
namespace Inicio_de_sesion
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.User = new System.Windows.Forms.Label();
            this.User_box = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Password_box = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.Login_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Exit_buttom = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // User
            // 
            resources.ApplyResources(this.User, "User");
            this.User.BackColor = System.Drawing.Color.Transparent;
            this.User.ForeColor = System.Drawing.Color.White;
            this.User.Name = "User";
            this.User.Click += new System.EventHandler(this.label1_Click);
            // 
            // User_box
            // 
            this.User_box.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.User_box, "User_box");
            this.User_box.Name = "User_box";
            // 
            // Password
            // 
            resources.ApplyResources(this.Password, "Password");
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.Name = "Password";
            // 
            // Password_box
            // 
            this.Password_box.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.Password_box, "Password_box");
            this.Password_box.Name = "Password_box";
            // 
            // Titulo
            // 
            resources.ApplyResources(this.Titulo, "Titulo");
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Name = "Titulo";
            this.Titulo.Click += new System.EventHandler(this.label3_Click);
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.Login_button, "Login_button");
            this.Login_button.Name = "Login_button";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit_buttom
            // 
            this.Exit_buttom.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.Exit_buttom, "Exit_buttom");
            this.Exit_buttom.Name = "Exit_buttom";
            this.Exit_buttom.UseVisualStyleBackColor = false;
            this.Exit_buttom.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Exit_buttom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Password_box);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.User_box);
            this.Controls.Add(this.User);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label User;
        private System.Windows.Forms.TextBox User_box;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox Password_box;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Exit_buttom;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}

