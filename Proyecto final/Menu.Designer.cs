
namespace Proyecto_final
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.proceso_buttom = new System.Windows.Forms.Button();
            this.seguimiento_buttom = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // proceso_buttom
            // 
            this.proceso_buttom.BackColor = System.Drawing.Color.Transparent;
            this.proceso_buttom.BackgroundImage = global::Proyecto_final.Properties.Resources.appointment_102882;
            this.proceso_buttom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.proceso_buttom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.proceso_buttom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proceso_buttom.Location = new System.Drawing.Point(403, 108);
            this.proceso_buttom.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.proceso_buttom.Name = "proceso_buttom";
            this.proceso_buttom.Size = new System.Drawing.Size(88, 77);
            this.proceso_buttom.TabIndex = 0;
            this.proceso_buttom.UseVisualStyleBackColor = false;
            this.proceso_buttom.Click += new System.EventHandler(this.proceso_buttom_Click);
            // 
            // seguimiento_buttom
            // 
            this.seguimiento_buttom.BackColor = System.Drawing.Color.Transparent;
            this.seguimiento_buttom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("seguimiento_buttom.BackgroundImage")));
            this.seguimiento_buttom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.seguimiento_buttom.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.seguimiento_buttom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.seguimiento_buttom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seguimiento_buttom.Location = new System.Drawing.Point(110, 292);
            this.seguimiento_buttom.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.seguimiento_buttom.Name = "seguimiento_buttom";
            this.seguimiento_buttom.Size = new System.Drawing.Size(85, 97);
            this.seguimiento_buttom.TabIndex = 1;
            this.seguimiento_buttom.UseVisualStyleBackColor = true;
            this.seguimiento_buttom.Click += new System.EventHandler(this.seguimiento_buttom_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(688, 312);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 77);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(318, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Proceso y creacion de citas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 253);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seguimiento de citas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(617, 253);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estadisticas de vacunacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 656);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bienvenido: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 658);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 27);
            this.textBox1.TabIndex = 7;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(898, 692);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proceso_buttom);
            this.Controls.Add(this.seguimiento_buttom);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Menu";
            this.Text = "Opciones";
            this.Load += new System.EventHandler(this.mainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button proceso_buttom;
        private System.Windows.Forms.Button seguimiento_buttom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}