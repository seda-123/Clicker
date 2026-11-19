namespace Clicker.UserControls
{
    partial class UcJugadores
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            LblTitle = new Label();
            LblDescription = new Label();
            panel2 = new Panel();
            dgvJugadores = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(LblDescription);
            panel1.Controls.Add(LblTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1096, 639);
            panel1.TabIndex = 0;
            // 
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.Font = new Font("Comfortaa", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitle.Location = new Point(19, 22);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(155, 44);
            LblTitle.TabIndex = 0;
            LblTitle.Text = "Jugadors";
            // 
            // LblDescription
            // 
            LblDescription.AutoSize = true;
            LblDescription.Font = new Font("Comfortaa Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblDescription.Location = new Point(19, 75);
            LblDescription.Name = "LblDescription";
            LblDescription.Size = new Size(467, 21);
            LblDescription.TabIndex = 1;
            LblDescription.Text = "Administra los perfiles de los alumnos que juegan a Farmer Clicker";
            LblDescription.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvJugadores);
            panel2.Location = new Point(25, 137);
            panel2.Name = "panel2";
            panel2.Size = new Size(1048, 454);
            panel2.TabIndex = 2;
            // 
            // dgvJugadores
            // 
            dgvJugadores.BackgroundColor = SystemColors.Window;
            dgvJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJugadores.Dock = DockStyle.Fill;
            dgvJugadores.GridColor = SystemColors.Window;
            dgvJugadores.Location = new Point(0, 0);
            dgvJugadores.Name = "dgvJugadores";
            dgvJugadores.Size = new Size(1048, 454);
            dgvJugadores.TabIndex = 0;
            dgvJugadores.CellContentClick += dgvJugadores_CellContentClick;
            // 
            // UcJugadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 243, 249);
            Controls.Add(panel1);
            Name = "UcJugadores";
            Size = new Size(1096, 639);
            Load += UcJugadores_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LblDescription;
        private Label LblTitle;
        private Panel panel2;
        private DataGridView dgvJugadores;
    }
}
