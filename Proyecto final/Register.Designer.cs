
namespace Proyecto_final
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.Carne = new System.Windows.Forms.Label();
            this.CPasswordRegister = new System.Windows.Forms.Label();
            this.PasswordRegister = new System.Windows.Forms.Label();
            this.QuestionRegister = new System.Windows.Forms.Label();
            this.UserRegister = new System.Windows.Forms.Label();
            this.CarneRegister_box = new System.Windows.Forms.TextBox();
            this.UserReister_box = new System.Windows.Forms.TextBox();
            this.PasswordRegister_box = new System.Windows.Forms.TextBox();
            this.CPasswordRegister_box = new System.Windows.Forms.TextBox();
            this.QuestionRegister_box = new System.Windows.Forms.TextBox();
            this.LogoRegister_img = new System.Windows.Forms.PictureBox();
            this.AcceptRegister_button = new System.Windows.Forms.Button();
            this.CancelRegister_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoRegister_img)).BeginInit();
            this.SuspendLayout();
            // 
            // Carne
            // 
            this.Carne.AutoSize = true;
            this.Carne.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carne.Location = new System.Drawing.Point(30, 68);
            this.Carne.Name = "Carne";
            this.Carne.Size = new System.Drawing.Size(83, 28);
            this.Carne.TabIndex = 0;
            this.Carne.Text = "CARNE";
            // 
            // CPasswordRegister
            // 
            this.CPasswordRegister.AutoSize = true;
            this.CPasswordRegister.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold);
            this.CPasswordRegister.Location = new System.Drawing.Point(30, 225);
            this.CPasswordRegister.Name = "CPasswordRegister";
            this.CPasswordRegister.Size = new System.Drawing.Size(153, 28);
            this.CPasswordRegister.TabIndex = 1;
            this.CPasswordRegister.Text = "CONTRASEÑA";
            this.CPasswordRegister.Click += new System.EventHandler(this.label2_Click);
            // 
            // PasswordRegister
            // 
            this.PasswordRegister.AutoSize = true;
            this.PasswordRegister.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold);
            this.PasswordRegister.Location = new System.Drawing.Point(30, 174);
            this.PasswordRegister.Name = "PasswordRegister";
            this.PasswordRegister.Size = new System.Drawing.Size(153, 28);
            this.PasswordRegister.TabIndex = 2;
            this.PasswordRegister.Text = "CONTRASEÑA";
            // 
            // QuestionRegister
            // 
            this.QuestionRegister.AutoSize = true;
            this.QuestionRegister.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold);
            this.QuestionRegister.Location = new System.Drawing.Point(30, 278);
            this.QuestionRegister.Name = "QuestionRegister";
            this.QuestionRegister.Size = new System.Drawing.Size(278, 28);
            this.QuestionRegister.TabIndex = 3;
            this.QuestionRegister.Text = "¿Cuál es su color favorito?";
            // 
            // UserRegister
            // 
            this.UserRegister.AutoSize = true;
            this.UserRegister.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserRegister.Location = new System.Drawing.Point(30, 120);
            this.UserRegister.Name = "UserRegister";
            this.UserRegister.Size = new System.Drawing.Size(104, 28);
            this.UserRegister.TabIndex = 4;
            this.UserRegister.Text = "USUARIO";
            // 
            // CarneRegister_box
            // 
            this.CarneRegister_box.BackColor = System.Drawing.Color.Silver;
            this.CarneRegister_box.Location = new System.Drawing.Point(371, 76);
            this.CarneRegister_box.Name = "CarneRegister_box";
            this.CarneRegister_box.Size = new System.Drawing.Size(163, 20);
            this.CarneRegister_box.TabIndex = 5;
            this.CarneRegister_box.TextChanged += new System.EventHandler(this.User_box_TextChanged);
            // 
            // UserReister_box
            // 
            this.UserReister_box.BackColor = System.Drawing.Color.Silver;
            this.UserReister_box.Location = new System.Drawing.Point(371, 128);
            this.UserReister_box.Name = "UserReister_box";
            this.UserReister_box.Size = new System.Drawing.Size(163, 20);
            this.UserReister_box.TabIndex = 6;
            this.UserReister_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PasswordRegister_box
            // 
            this.PasswordRegister_box.BackColor = System.Drawing.Color.Silver;
            this.PasswordRegister_box.Location = new System.Drawing.Point(371, 182);
            this.PasswordRegister_box.Name = "PasswordRegister_box";
            this.PasswordRegister_box.Size = new System.Drawing.Size(163, 20);
            this.PasswordRegister_box.TabIndex = 7;
            this.PasswordRegister_box.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // CPasswordRegister_box
            // 
            this.CPasswordRegister_box.BackColor = System.Drawing.Color.Silver;
            this.CPasswordRegister_box.Location = new System.Drawing.Point(371, 233);
            this.CPasswordRegister_box.Name = "CPasswordRegister_box";
            this.CPasswordRegister_box.Size = new System.Drawing.Size(163, 20);
            this.CPasswordRegister_box.TabIndex = 8;
            this.CPasswordRegister_box.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // QuestionRegister_box
            // 
            this.QuestionRegister_box.BackColor = System.Drawing.Color.Silver;
            this.QuestionRegister_box.Location = new System.Drawing.Point(371, 286);
            this.QuestionRegister_box.Name = "QuestionRegister_box";
            this.QuestionRegister_box.Size = new System.Drawing.Size(163, 20);
            this.QuestionRegister_box.TabIndex = 9;
            // 
            // LogoRegister_img
            // 
            this.LogoRegister_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoRegister_img.BackgroundImage")));
            this.LogoRegister_img.Location = new System.Drawing.Point(558, 67);
            this.LogoRegister_img.Name = "LogoRegister_img";
            this.LogoRegister_img.Size = new System.Drawing.Size(191, 258);
            this.LogoRegister_img.TabIndex = 10;
            this.LogoRegister_img.TabStop = false;
            // 
            // AcceptRegister_button
            // 
            this.AcceptRegister_button.Location = new System.Drawing.Point(35, 344);
            this.AcceptRegister_button.Name = "AcceptRegister_button";
            this.AcceptRegister_button.Size = new System.Drawing.Size(174, 42);
            this.AcceptRegister_button.TabIndex = 11;
            this.AcceptRegister_button.Text = "Aceptar";
            this.AcceptRegister_button.UseVisualStyleBackColor = true;
            this.AcceptRegister_button.Click += new System.EventHandler(this.AcceptRegister_button_Click);
            // 
            // CancelRegister_Button
            // 
            this.CancelRegister_Button.Location = new System.Drawing.Point(239, 344);
            this.CancelRegister_Button.Name = "CancelRegister_Button";
            this.CancelRegister_Button.Size = new System.Drawing.Size(174, 42);
            this.CancelRegister_Button.TabIndex = 12;
            this.CancelRegister_Button.Text = "Cancelar";
            this.CancelRegister_Button.UseVisualStyleBackColor = true;
            this.CancelRegister_Button.Click += new System.EventHandler(this.CancelRegister_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "Registro de usuario";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelRegister_Button);
            this.Controls.Add(this.AcceptRegister_button);
            this.Controls.Add(this.LogoRegister_img);
            this.Controls.Add(this.QuestionRegister_box);
            this.Controls.Add(this.CPasswordRegister_box);
            this.Controls.Add(this.PasswordRegister_box);
            this.Controls.Add(this.UserReister_box);
            this.Controls.Add(this.CarneRegister_box);
            this.Controls.Add(this.UserRegister);
            this.Controls.Add(this.QuestionRegister);
            this.Controls.Add(this.PasswordRegister);
            this.Controls.Add(this.CPasswordRegister);
            this.Controls.Add(this.Carne);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoRegister_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Carne;
        private System.Windows.Forms.Label CPasswordRegister;
        private System.Windows.Forms.Label PasswordRegister;
        private System.Windows.Forms.Label QuestionRegister;
        private System.Windows.Forms.Label UserRegister;
        private System.Windows.Forms.TextBox CarneRegister_box;
        private System.Windows.Forms.TextBox UserReister_box;
        private System.Windows.Forms.TextBox PasswordRegister_box;
        private System.Windows.Forms.TextBox CPasswordRegister_box;
        private System.Windows.Forms.TextBox QuestionRegister_box;
        private System.Windows.Forms.PictureBox LogoRegister_img;
        private System.Windows.Forms.Button AcceptRegister_button;
        private System.Windows.Forms.Button CancelRegister_Button;
        private System.Windows.Forms.Label label1;
    }
}