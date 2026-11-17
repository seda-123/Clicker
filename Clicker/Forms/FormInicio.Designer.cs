namespace Clicker
{
    partial class FormInicio
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
            PanelContenido = new Panel();
            PanelLateral = new Panel();
            Botons = new Panel();
            PanelUsuari = new Panel();
            Linea = new Label();
            configuracion = new Button();
            Metricas = new Button();
            Historial_partidas = new Button();
            Farmer_Clicker = new Button();
            jugadores = new Button();
            usuarios = new Button();
            inicio = new Button();
            PanelLogo = new Panel();
            logo = new Label();
            LblSubLogo = new Label();
            LblLogo = new Label();
            PanelLateral.SuspendLayout();
            Botons.SuspendLayout();
            PanelLogo.SuspendLayout();
            SuspendLayout();
            // 
            // PanelContenido
            // 
            PanelContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelContenido.Location = new Point(203, 0);
            PanelContenido.Name = "PanelContenido";
            PanelContenido.Size = new Size(1051, 916);
            PanelContenido.TabIndex = 0;
            PanelContenido.Paint += PanelContenido_Paint;
            // 
            // PanelLateral
            // 
            PanelLateral.BackColor = Color.FromArgb(6, 23, 68);
            PanelLateral.Controls.Add(Botons);
            PanelLateral.Controls.Add(PanelLogo);
            PanelLateral.Dock = DockStyle.Left;
            PanelLateral.Location = new Point(0, 0);
            PanelLateral.Name = "PanelLateral";
            PanelLateral.Size = new Size(203, 916);
            PanelLateral.TabIndex = 1;
            // 
            // Botons
            // 
            Botons.Controls.Add(PanelUsuari);
            Botons.Controls.Add(Linea);
            Botons.Controls.Add(configuracion);
            Botons.Controls.Add(Metricas);
            Botons.Controls.Add(Historial_partidas);
            Botons.Controls.Add(Farmer_Clicker);
            Botons.Controls.Add(jugadores);
            Botons.Controls.Add(usuarios);
            Botons.Controls.Add(inicio);
            Botons.Location = new Point(16, 112);
            Botons.Name = "Botons";
            Botons.Size = new Size(174, 715);
            Botons.TabIndex = 1;
            // 
            // PanelUsuari
            // 
            PanelUsuari.Location = new Point(9, 583);
            PanelUsuari.Name = "PanelUsuari";
            PanelUsuari.Size = new Size(145, 117);
            PanelUsuari.TabIndex = 7;
            // 
            // Linea
            // 
            Linea.AutoSize = true;
            Linea.ForeColor = Color.FromArgb(190, 205, 230);
            Linea.Location = new Point(-3, 551);
            Linea.Name = "Linea";
            Linea.Size = new Size(177, 15);
            Linea.TabIndex = 1;
            Linea.Text = "__________________________________";
            // 
            // configuracion
            // 
            configuracion.Cursor = Cursors.Hand;
            configuracion.FlatAppearance.BorderSize = 0;
            configuracion.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 43, 100);
            configuracion.FlatStyle = FlatStyle.Flat;
            configuracion.Font = new Font("Comfortaa", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            configuracion.ForeColor = Color.FromArgb(190, 205, 230);
            configuracion.Location = new Point(3, 492);
            configuracion.Name = "configuracion";
            configuracion.Size = new Size(167, 36);
            configuracion.TabIndex = 6;
            configuracion.Text = "⚙ Configuración";
            configuracion.TextAlign = ContentAlignment.MiddleLeft;
            configuracion.UseVisualStyleBackColor = true;
            // 
            // Metricas
            // 
            Metricas.Cursor = Cursors.Hand;
            Metricas.FlatAppearance.BorderSize = 0;
            Metricas.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 43, 100);
            Metricas.FlatStyle = FlatStyle.Flat;
            Metricas.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Metricas.ForeColor = Color.FromArgb(190, 205, 230);
            Metricas.Location = new Point(3, 431);
            Metricas.Name = "Metricas";
            Metricas.Size = new Size(167, 36);
            Metricas.TabIndex = 5;
            Metricas.Text = "▥ Métricas";
            Metricas.TextAlign = ContentAlignment.MiddleLeft;
            Metricas.UseVisualStyleBackColor = true;
            // 
            // Historial_partidas
            // 
            Historial_partidas.Cursor = Cursors.Hand;
            Historial_partidas.FlatAppearance.BorderSize = 0;
            Historial_partidas.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 43, 100);
            Historial_partidas.FlatStyle = FlatStyle.Flat;
            Historial_partidas.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Historial_partidas.ForeColor = Color.FromArgb(190, 205, 230);
            Historial_partidas.Location = new Point(4, 351);
            Historial_partidas.Name = "Historial_partidas";
            Historial_partidas.Size = new Size(167, 60);
            Historial_partidas.TabIndex = 4;
            Historial_partidas.Text = "◷ Historial de partidas";
            Historial_partidas.TextAlign = ContentAlignment.MiddleLeft;
            Historial_partidas.UseVisualStyleBackColor = true;
            // 
            // Farmer_Clicker
            // 
            Farmer_Clicker.Cursor = Cursors.Hand;
            Farmer_Clicker.FlatAppearance.BorderSize = 0;
            Farmer_Clicker.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 43, 100);
            Farmer_Clicker.FlatStyle = FlatStyle.Flat;
            Farmer_Clicker.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Farmer_Clicker.ForeColor = Color.FromArgb(190, 205, 230);
            Farmer_Clicker.Location = new Point(4, 288);
            Farmer_Clicker.Name = "Farmer_Clicker";
            Farmer_Clicker.Size = new Size(167, 36);
            Farmer_Clicker.TabIndex = 3;
            Farmer_Clicker.Text = "Farmer Clicker";
            Farmer_Clicker.TextAlign = ContentAlignment.MiddleLeft;
            Farmer_Clicker.UseVisualStyleBackColor = true;
            // 
            // jugadores
            // 
            jugadores.Cursor = Cursors.Hand;
            jugadores.FlatAppearance.BorderSize = 0;
            jugadores.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 43, 100);
            jugadores.FlatStyle = FlatStyle.Flat;
            jugadores.Font = new Font("Comfortaa", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            jugadores.ForeColor = Color.FromArgb(190, 205, 230);
            jugadores.Location = new Point(4, 224);
            jugadores.Name = "jugadores";
            jugadores.Size = new Size(167, 36);
            jugadores.TabIndex = 2;
            jugadores.Text = "♙ Jugadores";
            jugadores.TextAlign = ContentAlignment.MiddleLeft;
            jugadores.UseVisualStyleBackColor = true;
            // 
            // usuarios
            // 
            usuarios.Cursor = Cursors.Hand;
            usuarios.FlatAppearance.BorderSize = 0;
            usuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 43, 100);
            usuarios.FlatStyle = FlatStyle.Flat;
            usuarios.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usuarios.ForeColor = Color.FromArgb(190, 205, 230);
            usuarios.Location = new Point(4, 153);
            usuarios.Name = "usuarios";
            usuarios.Size = new Size(167, 36);
            usuarios.TabIndex = 1;
            usuarios.Text = "♧ Usuarios";
            usuarios.TextAlign = ContentAlignment.MiddleLeft;
            usuarios.UseVisualStyleBackColor = true;
            // 
            // inicio
            // 
            inicio.BackColor = Color.FromArgb(15, 43, 100);
            inicio.Cursor = Cursors.Hand;
            inicio.FlatAppearance.BorderSize = 0;
            inicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 43, 100);
            inicio.FlatStyle = FlatStyle.Flat;
            inicio.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inicio.ForeColor = Color.White;
            inicio.Location = new Point(4, 90);
            inicio.Name = "inicio";
            inicio.Size = new Size(167, 36);
            inicio.TabIndex = 0;
            inicio.Text = "⌂ Inicio";
            inicio.TextAlign = ContentAlignment.MiddleLeft;
            inicio.UseVisualStyleBackColor = false;
            // 
            // PanelLogo
            // 
            PanelLogo.BackColor = Color.FromArgb(6, 23, 68);
            PanelLogo.Controls.Add(logo);
            PanelLogo.Controls.Add(LblSubLogo);
            PanelLogo.Controls.Add(LblLogo);
            PanelLogo.Location = new Point(17, 43);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(174, 63);
            PanelLogo.TabIndex = 0;
            // 
            // logo
            // 
            logo.BackColor = Color.FromArgb(6, 23, 68);
            logo.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logo.ForeColor = Color.White;
            logo.Location = new Point(127, -4);
            logo.Name = "logo";
            logo.Size = new Size(47, 45);
            logo.TabIndex = 1;
            logo.Text = "\t🎮";
            logo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblSubLogo
            // 
            LblSubLogo.AutoSize = true;
            LblSubLogo.Font = new Font("Comfortaa", 8.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSubLogo.ForeColor = Color.FromArgb(160, 180, 220);
            LblSubLogo.Location = new Point(8, 33);
            LblSubLogo.Name = "LblSubLogo";
            LblSubLogo.Size = new Size(121, 18);
            LblSubLogo.TabIndex = 1;
            LblSubLogo.Text = "CLICKER MANAGER";
            // 
            // LblLogo
            // 
            LblLogo.AutoSize = true;
            LblLogo.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblLogo.ForeColor = Color.White;
            LblLogo.Location = new Point(3, -4);
            LblLogo.Name = "LblLogo";
            LblLogo.Size = new Size(95, 34);
            LblLogo.TabIndex = 0;
            LblLogo.Text = "Farmer";
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 916);
            Controls.Add(PanelLateral);
            Controls.Add(PanelContenido);
            Name = "FormInicio";
            Text = "Form3";
            Load += FormInicio_Load;
            PanelLateral.ResumeLayout(false);
            Botons.ResumeLayout(false);
            Botons.PerformLayout();
            PanelLogo.ResumeLayout(false);
            PanelLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelContenido;
        private Panel PanelLateral;
        private Panel Botons;
        private Panel PanelUsuari;
        private Label Linea;
        private Button configuracion;
        private Button Metricas;
        private Button Historial_partidas;
        private Button Farmer_Clicker;
        private Button jugadores;
        private Button usuarios;
        private Button inicio;
        private Panel PanelLogo;
        private Label logo;
        private Label LblSubLogo;
        private Label LblLogo;
    }
}