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
            PanelGraficoActividad = new Clicker.Controles.TarjetaDashboard();
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
            LblTituloGrafico = new Label();
            LblSubtituloGrafico = new Label();
            PanelGraficoLineas = new Panel();
            PanelDashboard.SuspendLayout();
            PanelGraficoActividad.SuspendLayout();
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
            PanelDashboard.Controls.Add(PanelGraficoActividad);
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
            // PanelGraficoActividad
            // 
            PanelGraficoActividad.BackColor = Color.Transparent;
            PanelGraficoActividad.Controls.Add(PanelGraficoLineas);
            PanelGraficoActividad.Controls.Add(LblSubtituloGrafico);
            PanelGraficoActividad.Controls.Add(LblTituloGrafico);
            PanelGraficoActividad.Location = new Point(60, 410);
            PanelGraficoActividad.Name = "PanelGraficoActividad";
            PanelGraficoActividad.Padding = new Padding(12);
            PanelGraficoActividad.Size = new Size(1029, 288);
            PanelGraficoActividad.TabIndex = 8;
            // 
            // PanelDuracion
            // 
            PanelDuracion.BackColor = Color.Transparent;
            PanelDuracion.Controls.Add(lblDescripcioDurada);
            PanelDuracion.Controls.Add(pictureBox3);
            PanelDuracion.Controls.Add(LblValorDuracion);
            PanelDuracion.Controls.Add(lbltitolDurada);
            PanelDuracion.Location = new Point(1103, 100);
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
            lblDescripcioDurada.Size = new Size(110, 18);
            lblDescripcioDurada.TabIndex = 15;
            lblDescripcioDurada.Text = "Temps total de joc";
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
            lbltitolDurada.Size = new Size(61, 21);
            lbltitolDurada.TabIndex = 12;
            lbltitolDurada.Text = "Durada";
            // 
            // PanelMonedas
            // 
            PanelMonedas.BackColor = Color.Transparent;
            PanelMonedas.Controls.Add(lbldescripcioMonedes);
            PanelMonedas.Controls.Add(pictureBox2);
            PanelMonedas.Controls.Add(LblValorMonedas);
            PanelMonedas.Controls.Add(lblTitulMonedas);
            PanelMonedas.Location = new Point(761, 100);
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
            lbldescripcioMonedes.Size = new Size(189, 18);
            lbldescripcioMonedes.TabIndex = 11;
            lbldescripcioMonedes.Text = "Total de monedes aconseguides";
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
            lblTitulMonedas.Size = new Size(73, 21);
            lblTitulMonedas.TabIndex = 8;
            lblTitulMonedas.Text = "Monedes";
            // 
            // PanelSesiones
            // 
            PanelSesiones.BackColor = Color.Transparent;
            PanelSesiones.Controls.Add(lblSessionsDesc);
            PanelSesiones.Controls.Add(pictureBox1);
            PanelSesiones.Controls.Add(lblValorSesions);
            PanelSesiones.Controls.Add(lblTitulSessions);
            PanelSesiones.Location = new Point(413, 100);
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
            lblSessionsDesc.Size = new Size(169, 18);
            lblSessionsDesc.TabIndex = 7;
            lblSessionsDesc.Text = "Total de sessions realitzades";
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
            lblTitulSessions.Size = new Size(70, 21);
            lblTitulSessions.TabIndex = 4;
            lblTitulSessions.Text = "Sessions";
            // 
            // PanelAlumnos
            // 
            PanelAlumnos.BackColor = Color.Transparent;
            PanelAlumnos.Controls.Add(LblDescripcionAlumnos);
            PanelAlumnos.Controls.Add(LblValorAlumnos);
            PanelAlumnos.Controls.Add(PicAlumnos);
            PanelAlumnos.Controls.Add(LblTituloAlumnos);
            PanelAlumnos.Location = new Point(60, 100);
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
            LblDescripcionAlumnos.Size = new Size(149, 18);
            LblDescripcionAlumnos.TabIndex = 3;
            LblDescripcionAlumnos.Text = "Total d'alumnes registrats";
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
            LblTituloAlumnos.Size = new Size(68, 21);
            LblTituloAlumnos.TabIndex = 0;
            LblTituloAlumnos.Text = "Alumnes";
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
            // LblTituloGrafico
            // 
            LblTituloGrafico.AutoSize = true;
            LblTituloGrafico.Font = new Font("Comfortaa", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTituloGrafico.ForeColor = Color.FromArgb(16, 24, 40);
            LblTituloGrafico.Location = new Point(20, 18);
            LblTituloGrafico.Name = "LblTituloGrafico";
            LblTituloGrafico.Size = new Size(157, 21);
            LblTituloGrafico.TabIndex = 0;
            LblTituloGrafico.Text = "Actividad de partidas";
            // 
            // LblSubtituloGrafico
            // 
            LblSubtituloGrafico.AutoSize = true;
            LblSubtituloGrafico.Font = new Font("Comfortaa", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblSubtituloGrafico.ForeColor = Color.FromArgb(102, 112, 133);
            LblSubtituloGrafico.Location = new Point(20, 48);
            LblSubtituloGrafico.Name = "LblSubtituloGrafico";
            LblSubtituloGrafico.Size = new Size(277, 18);
            LblSubtituloGrafico.TabIndex = 1;
            LblSubtituloGrafico.Text = "Sesiones registradas durante los últimos 18 días";
            // 
            // PanelGraficoLineas
            // 
            PanelGraficoLineas.BackColor = Color.White;
            PanelGraficoLineas.Location = new Point(20, 85);
            PanelGraficoLineas.Name = "PanelGraficoLineas";
            PanelGraficoLineas.Size = new Size(989, 180);
            PanelGraficoLineas.TabIndex = 2;
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
            PanelGraficoActividad.ResumeLayout(false);
            PanelGraficoActividad.PerformLayout();
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
        private Controles.TarjetaDashboard PanelGraficoActividad;
        private Label LblTituloGrafico;
        private Label LblSubtituloGrafico;
        private Panel PanelGraficoLineas;
    }
}
