namespace Clicker.UserControls
{
    partial class UcInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcInicio));
            PanelDashboard = new Panel();
            ProgresoPorNivelPanel = new Clicker.Controles.TarjetaDashboard();
            PartidasRecientes = new Clicker.Controles.TarjetaDashboard();
            PanelDuracion = new Clicker.Controles.TarjetaDashboard();
            lblDescripcioDurada = new Label();
            pictureBox3 = new PictureBox();
            LblValorDuracion = new Label();
            lbltitolDurada = new Label();
            PanelMonedas = new Clicker.Controles.TarjetaDashboard();
            lbldescripcioMonedes = new Label();
            pictureBox2 = new PictureBox();
            LblValorMonedas = new Label();
            lblTitulMonedas = new Label();
            PanelSesiones = new Clicker.Controles.TarjetaDashboard();
            lblSessionsDesc = new Label();
            pictureBox1 = new PictureBox();
            lblValorSesions = new Label();
            lblTitulSessions = new Label();
            PanelAlumnos = new Clicker.Controles.TarjetaDashboard();
            LblDescripcionAlumnos = new Label();
            LblValorAlumnos = new Label();
            PicAlumnos = new PictureBox();
            LblTituloAlumnos = new Label();
            LblDescripcion = new Label();
            LblBienvenida = new Label();
            PartidasTitol = new Label();
            PartidasDesc = new Label();
            ProgresoDesc = new Label();
            ProgresoTitol = new Label();
            PanelDashboard.SuspendLayout();
            ProgresoPorNivelPanel.SuspendLayout();
            PartidasRecientes.SuspendLayout();
            PanelDuracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            PanelMonedas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            PanelSesiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicAlumnos).BeginInit();
            SuspendLayout();
            // 
            // PanelDashboard
            // 
            PanelDashboard.Controls.Add(ProgresoPorNivelPanel);
            PanelDashboard.Controls.Add(PartidasRecientes);
            PanelDashboard.Controls.Add(PanelDuracion);
            PanelDashboard.Controls.Add(PanelMonedas);
            PanelDashboard.Controls.Add(PanelSesiones);
            PanelDashboard.Controls.Add(PanelAlumnos);
            PanelDashboard.Controls.Add(LblDescripcion);
            PanelDashboard.Controls.Add(LblBienvenida);
            PanelDashboard.Dock = DockStyle.Fill;
            PanelDashboard.Location = new Point(0, 0);
            PanelDashboard.Name = "PanelDashboard";
            PanelDashboard.Size = new Size(1871, 1280);
            PanelDashboard.TabIndex = 0;
            // 
            // ProgresoPorNivelPanel
            // 
            ProgresoPorNivelPanel.BackColor = Color.Transparent;
            ProgresoPorNivelPanel.Controls.Add(ProgresoDesc);
            ProgresoPorNivelPanel.Controls.Add(ProgresoTitol);
            ProgresoPorNivelPanel.Location = new Point(1112, 403);
            ProgresoPorNivelPanel.Name = "ProgresoPorNivelPanel";
            ProgresoPorNivelPanel.Padding = new Padding(12);
            ProgresoPorNivelPanel.Size = new Size(549, 429);
            ProgresoPorNivelPanel.TabIndex = 9;
            // 
            // PartidasRecientes
            // 
            PartidasRecientes.BackColor = Color.Transparent;
            PartidasRecientes.Controls.Add(PartidasDesc);
            PartidasRecientes.Controls.Add(PartidasTitol);
            PartidasRecientes.Location = new Point(60, 403);
            PartidasRecientes.Name = "PartidasRecientes";
            PartidasRecientes.Padding = new Padding(12);
            PartidasRecientes.Size = new Size(920, 429);
            PartidasRecientes.TabIndex = 8;
            // 
            // PanelDuracion
            // 
            PanelDuracion.BackColor = Color.Transparent;
            PanelDuracion.Controls.Add(lblDescripcioDurada);
            PanelDuracion.Controls.Add(pictureBox3);
            PanelDuracion.Controls.Add(LblValorDuracion);
            PanelDuracion.Controls.Add(lbltitolDurada);
            PanelDuracion.Location = new Point(1379, 118);
            PanelDuracion.Name = "PanelDuracion";
            PanelDuracion.Padding = new Padding(12);
            PanelDuracion.Size = new Size(282, 130);
            PanelDuracion.TabIndex = 7;
            // 
            // lblDescripcioDurada
            // 
            lblDescripcioDurada.AutoSize = true;
            lblDescripcioDurada.Font = new Font("Comfortaa", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcioDurada.ForeColor = Color.FromArgb(152, 162, 179);
            lblDescripcioDurada.Location = new Point(15, 105);
            lblDescripcioDurada.Name = "lblDescripcioDurada";
            lblDescripcioDurada.Size = new Size(133, 18);
            lblDescripcioDurada.TabIndex = 15;
            lblDescripcioDurada.Text = "Tiempo total del juego";
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = Properties.Resources.durada;
            pictureBox3.Image = Properties.Resources.durada;
            pictureBox3.InitialImage = Properties.Resources.durada;
            pictureBox3.Location = new Point(15, 55);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // LblValorDuracion
            // 
            LblValorDuracion.AutoSize = true;
            LblValorDuracion.Font = new Font("Comfortaa", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblValorDuracion.ForeColor = Color.FromArgb(16, 24, 40);
            LblValorDuracion.Location = new Point(53, 56);
            LblValorDuracion.Name = "LblValorDuracion";
            LblValorDuracion.Size = new Size(0, 52);
            LblValorDuracion.TabIndex = 14;
            // 
            // lbltitolDurada
            // 
            lbltitolDurada.AutoSize = true;
            lbltitolDurada.Font = new Font("Comfortaa SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltitolDurada.ForeColor = Color.FromArgb(102, 112, 133);
            lbltitolDurada.Location = new Point(15, 18);
            lbltitolDurada.Name = "lbltitolDurada";
            lbltitolDurada.Size = new Size(97, 21);
            lbltitolDurada.TabIndex = 12;
            lbltitolDurada.Text = "Tiempo total";
            // 
            // PanelMonedas
            // 
            PanelMonedas.BackColor = Color.Transparent;
            PanelMonedas.Controls.Add(lbldescripcioMonedes);
            PanelMonedas.Controls.Add(pictureBox2);
            PanelMonedas.Controls.Add(LblValorMonedas);
            PanelMonedas.Controls.Add(lblTitulMonedas);
            PanelMonedas.Location = new Point(947, 118);
            PanelMonedas.Name = "PanelMonedas";
            PanelMonedas.Padding = new Padding(12);
            PanelMonedas.Size = new Size(282, 130);
            PanelMonedas.TabIndex = 6;
            // 
            // lbldescripcioMonedes
            // 
            lbldescripcioMonedes.AutoSize = true;
            lbldescripcioMonedes.Font = new Font("Comfortaa", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbldescripcioMonedes.ForeColor = Color.FromArgb(152, 162, 179);
            lbldescripcioMonedes.Location = new Point(15, 105);
            lbldescripcioMonedes.Name = "lbldescripcioMonedes";
            lbldescripcioMonedes.Size = new Size(185, 18);
            lbldescripcioMonedes.TabIndex = 11;
            lbldescripcioMonedes.Text = "Total de monedas recolectadas";
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = Properties.Resources.monedas;
            pictureBox2.Image = Properties.Resources.monedas;
            pictureBox2.InitialImage = Properties.Resources.monedas;
            pictureBox2.Location = new Point(15, 55);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // LblValorMonedas
            // 
            LblValorMonedas.AutoSize = true;
            LblValorMonedas.Font = new Font("Comfortaa", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblValorMonedas.ForeColor = Color.FromArgb(16, 24, 40);
            LblValorMonedas.Location = new Point(53, 56);
            LblValorMonedas.Name = "LblValorMonedas";
            LblValorMonedas.Size = new Size(0, 52);
            LblValorMonedas.TabIndex = 10;
            // 
            // lblTitulMonedas
            // 
            lblTitulMonedas.AutoSize = true;
            lblTitulMonedas.Font = new Font("Comfortaa SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulMonedas.ForeColor = Color.FromArgb(102, 112, 133);
            lblTitulMonedas.Location = new Point(15, 18);
            lblTitulMonedas.Name = "lblTitulMonedas";
            lblTitulMonedas.Size = new Size(74, 21);
            lblTitulMonedas.TabIndex = 8;
            lblTitulMonedas.Text = "Monedas";
            // 
            // PanelSesiones
            // 
            PanelSesiones.BackColor = Color.Transparent;
            PanelSesiones.Controls.Add(lblSessionsDesc);
            PanelSesiones.Controls.Add(pictureBox1);
            PanelSesiones.Controls.Add(lblValorSesions);
            PanelSesiones.Controls.Add(lblTitulSessions);
            PanelSesiones.Location = new Point(515, 118);
            PanelSesiones.Name = "PanelSesiones";
            PanelSesiones.Padding = new Padding(12);
            PanelSesiones.Size = new Size(282, 130);
            PanelSesiones.TabIndex = 5;
            // 
            // lblSessionsDesc
            // 
            lblSessionsDesc.AutoSize = true;
            lblSessionsDesc.Font = new Font("Comfortaa", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSessionsDesc.ForeColor = Color.FromArgb(152, 162, 179);
            lblSessionsDesc.Location = new Point(15, 105);
            lblSessionsDesc.Name = "lblSessionsDesc";
            lblSessionsDesc.Size = new Size(166, 18);
            lblSessionsDesc.TabIndex = 7;
            lblSessionsDesc.Text = "Total de sesiones realizadas";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.sessions;
            pictureBox1.Image = Properties.Resources.sessions;
            pictureBox1.InitialImage = Properties.Resources.sessions;
            pictureBox1.Location = new Point(15, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblValorSesions
            // 
            lblValorSesions.AutoSize = true;
            lblValorSesions.Font = new Font("Comfortaa", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorSesions.ForeColor = Color.FromArgb(16, 24, 40);
            lblValorSesions.Location = new Point(53, 56);
            lblValorSesions.Name = "lblValorSesions";
            lblValorSesions.Size = new Size(0, 52);
            lblValorSesions.TabIndex = 6;
            // 
            // lblTitulSessions
            // 
            lblTitulSessions.AutoSize = true;
            lblTitulSessions.Font = new Font("Comfortaa SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulSessions.ForeColor = Color.FromArgb(102, 112, 133);
            lblTitulSessions.Location = new Point(15, 18);
            lblTitulSessions.Name = "lblTitulSessions";
            lblTitulSessions.Size = new Size(71, 21);
            lblTitulSessions.TabIndex = 4;
            lblTitulSessions.Text = "Sesiones";
            // 
            // PanelAlumnos
            // 
            PanelAlumnos.BackColor = Color.Transparent;
            PanelAlumnos.Controls.Add(LblDescripcionAlumnos);
            PanelAlumnos.Controls.Add(LblValorAlumnos);
            PanelAlumnos.Controls.Add(PicAlumnos);
            PanelAlumnos.Controls.Add(LblTituloAlumnos);
            PanelAlumnos.Location = new Point(60, 118);
            PanelAlumnos.Name = "PanelAlumnos";
            PanelAlumnos.Padding = new Padding(12);
            PanelAlumnos.Size = new Size(282, 130);
            PanelAlumnos.TabIndex = 4;
            // 
            // LblDescripcionAlumnos
            // 
            LblDescripcionAlumnos.AutoSize = true;
            LblDescripcionAlumnos.Font = new Font("Comfortaa", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblDescripcionAlumnos.ForeColor = Color.FromArgb(152, 162, 179);
            LblDescripcionAlumnos.Location = new Point(20, 105);
            LblDescripcionAlumnos.Name = "LblDescripcionAlumnos";
            LblDescripcionAlumnos.Size = new Size(170, 18);
            LblDescripcionAlumnos.TabIndex = 3;
            LblDescripcionAlumnos.Text = "Total de alumnos registrados";
            // 
            // LblValorAlumnos
            // 
            LblValorAlumnos.AutoSize = true;
            LblValorAlumnos.Font = new Font("Comfortaa", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblValorAlumnos.ForeColor = Color.FromArgb(16, 24, 40);
            LblValorAlumnos.Location = new Point(58, 56);
            LblValorAlumnos.Name = "LblValorAlumnos";
            LblValorAlumnos.Size = new Size(0, 52);
            LblValorAlumnos.TabIndex = 2;
            // 
            // PicAlumnos
            // 
            PicAlumnos.ErrorImage = (Image)resources.GetObject("PicAlumnos.ErrorImage");
            PicAlumnos.Image = Properties.Resources.alumnes;
            PicAlumnos.InitialImage = (Image)resources.GetObject("PicAlumnos.InitialImage");
            PicAlumnos.Location = new Point(20, 55);
            PicAlumnos.Name = "PicAlumnos";
            PicAlumnos.Size = new Size(36, 36);
            PicAlumnos.SizeMode = PictureBoxSizeMode.Zoom;
            PicAlumnos.TabIndex = 1;
            PicAlumnos.TabStop = false;
            // 
            // LblTituloAlumnos
            // 
            LblTituloAlumnos.AutoSize = true;
            LblTituloAlumnos.Font = new Font("Comfortaa SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTituloAlumnos.ForeColor = Color.FromArgb(102, 112, 133);
            LblTituloAlumnos.Location = new Point(20, 18);
            LblTituloAlumnos.Name = "LblTituloAlumnos";
            LblTituloAlumnos.Size = new Size(69, 21);
            LblTituloAlumnos.TabIndex = 0;
            LblTituloAlumnos.Text = "Alumnos";
            // 
            // LblDescripcion
            // 
            LblDescripcion.AutoSize = true;
            LblDescripcion.Font = new Font("Comfortaa", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblDescripcion.ForeColor = Color.FromArgb(102, 112, 133);
            LblDescripcion.Location = new Point(60, 58);
            LblDescripcion.Name = "LblDescripcion";
            LblDescripcion.Size = new Size(391, 21);
            LblDescripcion.TabIndex = 1;
            LblDescripcion.Text = "Resumen de la actividad de Farmer Clicker en tu centro.";
            // 
            // LblBienvenida
            // 
            LblBienvenida.AutoSize = true;
            LblBienvenida.Font = new Font("Comfortaa SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblBienvenida.ForeColor = Color.FromArgb(16, 24, 40);
            LblBienvenida.Location = new Point(60, 25);
            LblBienvenida.Name = "LblBienvenida";
            LblBienvenida.Size = new Size(141, 30);
            LblBienvenida.TabIndex = 0;
            LblBienvenida.Text = "Buenos días,";
            // 
            // PartidasTitol
            // 
            PartidasTitol.AutoSize = true;
            PartidasTitol.Font = new Font("Comfortaa", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartidasTitol.ForeColor = Color.FromArgb(102, 112, 133);
            PartidasTitol.Location = new Point(23, 23);
            PartidasTitol.Name = "PartidasTitol";
            PartidasTitol.Size = new Size(133, 21);
            PartidasTitol.TabIndex = 0;
            PartidasTitol.Text = "Partidas recientes";
            // 
            // PartidasDesc
            // 
            PartidasDesc.AutoSize = true;
            PartidasDesc.Font = new Font("Comfortaa", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartidasDesc.ForeColor = Color.FromArgb(152, 162, 179);
            PartidasDesc.Location = new Point(29, 47);
            PartidasDesc.Name = "PartidasDesc";
            PartidasDesc.Size = new Size(264, 18);
            PartidasDesc.TabIndex = 4;
            PartidasDesc.Text = "Última actividad registrada en Farmer Clicker";
            PartidasDesc.Click += label1_Click;
            // 
            // ProgresoDesc
            // 
            ProgresoDesc.AutoSize = true;
            ProgresoDesc.Font = new Font("Comfortaa", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProgresoDesc.ForeColor = Color.FromArgb(152, 162, 179);
            ProgresoDesc.Location = new Point(21, 47);
            ProgresoDesc.Name = "ProgresoDesc";
            ProgresoDesc.Size = new Size(201, 18);
            ProgresoDesc.TabIndex = 6;
            ProgresoDesc.Text = "Distribución actual de los alumnos";
            // 
            // ProgresoTitol
            // 
            ProgresoTitol.AutoSize = true;
            ProgresoTitol.Font = new Font("Comfortaa", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProgresoTitol.ForeColor = Color.FromArgb(102, 112, 133);
            ProgresoTitol.Location = new Point(15, 23);
            ProgresoTitol.Name = "ProgresoTitol";
            ProgresoTitol.Size = new Size(134, 21);
            ProgresoTitol.TabIndex = 5;
            ProgresoTitol.Text = "Progreso por nivel";
            // 
            // UcInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 243, 249);
            Controls.Add(PanelDashboard);
            Font = new Font("Comfortaa", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UcInicio";
            Size = new Size(1871, 1280);
            PanelDashboard.ResumeLayout(false);
            PanelDashboard.PerformLayout();
            ProgresoPorNivelPanel.ResumeLayout(false);
            ProgresoPorNivelPanel.PerformLayout();
            PartidasRecientes.ResumeLayout(false);
            PartidasRecientes.PerformLayout();
            PanelDuracion.ResumeLayout(false);
            PanelDuracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            PanelMonedas.ResumeLayout(false);
            PanelMonedas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            PanelSesiones.ResumeLayout(false);
            PanelSesiones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelAlumnos.ResumeLayout(false);
            PanelAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelDashboard;
        private Label LblBienvenida;
        private Label LblDescripcion;
        private Panel panel4;
        private Controles.TarjetaDashboard PanelDuracion;
        private Controles.TarjetaDashboard PanelMonedas;
        private Controles.TarjetaDashboard PanelSesiones;
        private Controles.TarjetaDashboard PanelAlumnos;
        private Label LblTituloAlumnos;
        private PictureBox PicAlumnos;
        private Label LblDescripcionAlumnos;
        private Label LblValorAlumnos;
        private Label lblDescripcioDurada;
        private PictureBox pictureBox3;
        private Label LblValorDuracion;
        private Label lbltitolDurada;
        private Label lbldescripcioMonedes;
        private PictureBox pictureBox2;
        private Label LblValorMonedas;
        private Label lblTitulMonedas;
        private Label lblSessionsDesc;
        private PictureBox pictureBox1;
        private Label lblValorSesions;
        private Label lblTitulSessions;
        private Controles.TarjetaDashboard PartidasRecientes;
        private Controles.TarjetaDashboard ProgresoPorNivelPanel;
        private Label PartidasTitol;
        private Label PartidasDesc;
        private Label ProgresoDesc;
        private Label ProgresoTitol;
    }
}
