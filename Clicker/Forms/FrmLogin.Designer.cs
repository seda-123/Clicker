namespace Clicker
{
    partial class inici_sesio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            inici_sessio = new Button();
            registrat = new LinkLabel();
            missatge_registrat = new Label();
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
            panel1.Controls.Add(inici_sessio);
            panel1.Controls.Add(registrat);
            panel1.Controls.Add(missatge_registrat);
            panel1.Controls.Add(contra);
            panel1.Controls.Add(Nom);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(titol);
            panel1.Controls.Add(logo);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 450);
            panel1.TabIndex = 0;
            // 
            // inici_sessio
            // 
            inici_sessio.BackColor = Color.Transparent;
            inici_sessio.Font = new Font("Comfortaa", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inici_sessio.ForeColor = Color.MidnightBlue;
            inici_sessio.Location = new Point(255, 218);
            inici_sessio.Name = "inici_sessio";
            inici_sessio.Size = new Size(110, 37);
            inici_sessio.TabIndex = 8;
            inici_sessio.Text = "Iniciar sessió";
            inici_sessio.UseVisualStyleBackColor = false;
            inici_sessio.Click += inici_sessio_Click;
            // 
            // registrat
            // 
            registrat.AutoSize = true;
            registrat.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registrat.LinkColor = Color.MidnightBlue;
            registrat.Location = new Point(274, 309);
            registrat.Name = "registrat";
            registrat.Size = new Size(91, 26);
            registrat.TabIndex = 7;
            registrat.TabStop = true;
            registrat.Text = "Registra't!";
            // 
            // missatge_registrat
            // 
            missatge_registrat.AutoSize = true;
            missatge_registrat.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            missatge_registrat.ForeColor = Color.MidnightBlue;
            missatge_registrat.Location = new Point(37, 309);
            missatge_registrat.Name = "missatge_registrat";
            missatge_registrat.Size = new Size(249, 26);
            missatge_registrat.TabIndex = 6;
            missatge_registrat.Text = "Encara no tens un compte? ";
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
            titol.Location = new Point(109, 36);
            titol.Name = "titol";
            titol.Size = new Size(278, 57);
            titol.TabIndex = 1;
            titol.Text = "Inici de sessió";
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
            // inici_sesio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 243, 249);
            ClientSize = new Size(418, 479);
            Controls.Add(panel1);
            Name = "inici_sesio";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label logo;
        private Label titol;
        private Label Nom;
        private TextBox textBox2;
        private TextBox textBox1;
        private LinkLabel registrat;
        private Label missatge_registrat;
        private Label contra;
        private Button inici_sessio;
    }
}
