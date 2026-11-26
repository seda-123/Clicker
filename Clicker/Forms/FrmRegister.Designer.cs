namespace Clicker
{
    partial class registre
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
            panel1 = new Panel();
            label1 = new Label();
            textBox3 = new TextBox();
            inici_sessio = new Button();
            contra = new Label();
            Nom = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            titol = new Label();
            logo = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(inici_sessio);
            panel1.Controls.Add(contra);
            panel1.Controls.Add(Nom);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(titol);
            panel1.Controls.Add(logo);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 452);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comfortaa", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(28, 225);
            label1.Name = "label1";
            label1.Size = new Size(173, 21);
            label1.TabIndex = 10;
            label1.Text = "Repeteix la contrasenya";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(207, 223);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '·';
            textBox3.Size = new Size(158, 23);
            textBox3.TabIndex = 9;
            // 
            // inici_sessio
            // 
            inici_sessio.BackColor = Color.Transparent;
            inici_sessio.Font = new Font("Comfortaa", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inici_sessio.ForeColor = Color.MidnightBlue;
            inici_sessio.Location = new Point(255, 277);
            inici_sessio.Name = "inici_sessio";
            inici_sessio.Size = new Size(110, 37);
            inici_sessio.TabIndex = 8;
            inici_sessio.Text = "Registra't!";
            inici_sessio.UseVisualStyleBackColor = false;
            // 
            // contra
            // 
            contra.AutoSize = true;
            contra.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contra.ForeColor = Color.MidnightBlue;
            contra.Location = new Point(48, 167);
            contra.Name = "contra";
            contra.Size = new Size(153, 34);
            contra.TabIndex = 5;
            contra.Text = "Contrasenya";
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nom.ForeColor = Color.MidnightBlue;
            Nom.Location = new Point(135, 118);
            Nom.Name = "Nom";
            Nom.Size = new Size(66, 34);
            Nom.TabIndex = 4;
            Nom.Text = "Nom";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(207, 178);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '·';
            textBox2.Size = new Size(158, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 23);
            textBox1.TabIndex = 2;
            // 
            // titol
            // 
            titol.AutoSize = true;
            titol.BackColor = Color.White;
            titol.Font = new Font("Comfortaa", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titol.ForeColor = Color.MidnightBlue;
            titol.Location = new Point(201, 36);
            titol.Name = "titol";
            titol.Size = new Size(170, 57);
            titol.TabIndex = 1;
            titol.Text = "Registre";
            // 
            // logo
            // 
            logo.BackColor = Color.RoyalBlue;
            logo.Font = new Font("Segoe UI Emoji", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logo.ForeColor = Color.White;
            logo.Location = new Point(-1, -20);
            logo.Name = "logo";
            logo.Size = new Size(93, 102);
            logo.TabIndex = 0;
            logo.Text = "\t🎮";
            logo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // registre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 476);
            Controls.Add(panel1);
            Name = "registre";
            Text = "Form2";
            Load += registre_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button inici_sessio;
        private Label contra;
        private Label Nom;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label titol;
        private Label logo;
        private Label label1;
        private TextBox textBox3;
    }
}