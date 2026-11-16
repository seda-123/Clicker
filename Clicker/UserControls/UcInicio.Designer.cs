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
            PanelDashboard = new Panel();
            LblDescripcion = new Label();
            LblBienvenida = new Label();
            PanelAlumnos = new Clicker.Controles.TarjetaDashboard();
            PanelSesiones = new Clicker.Controles.TarjetaDashboard();
            PanelMonedas = new Clicker.Controles.TarjetaDashboard();
            PanelDuracion = new Clicker.Controles.TarjetaDashboard();
            PanelDashboard.SuspendLayout();
            SuspendLayout();
            // 
            // PanelDashboard
            // 
            PanelDashboard.Controls.Add(PanelDuracion);
            PanelDashboard.Controls.Add(PanelMonedas);
            PanelDashboard.Controls.Add(PanelSesiones);
            PanelDashboard.Controls.Add(PanelAlumnos);
            PanelDashboard.Controls.Add(LblDescripcion);
            PanelDashboard.Controls.Add(LblBienvenida);
            PanelDashboard.Dock = DockStyle.Fill;
            PanelDashboard.Location = new Point(0, 0);
            PanelDashboard.Name = "PanelDashboard";
            PanelDashboard.Size = new Size(1149, 1027);
            PanelDashboard.TabIndex = 0;
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
            // PanelAlumnos
            // 
            PanelAlumnos.BackColor = Color.Transparent;
            PanelAlumnos.Location = new Point(60, 100);
            PanelAlumnos.Name = "PanelAlumnos";
            PanelAlumnos.Padding = new Padding(12);
            PanelAlumnos.Size = new Size(282, 130);
            PanelAlumnos.TabIndex = 4;
            // 
            // PanelSesiones
            // 
            PanelSesiones.BackColor = Color.Transparent;
            PanelSesiones.Location = new Point(354, 100);
            PanelSesiones.Name = "PanelSesiones";
            PanelSesiones.Padding = new Padding(12);
            PanelSesiones.Size = new Size(282, 130);
            PanelSesiones.TabIndex = 5;
            // 
            // PanelMonedas
            // 
            PanelMonedas.BackColor = Color.Transparent;
            PanelMonedas.Location = new Point(648, 100);
            PanelMonedas.Name = "PanelMonedas";
            PanelMonedas.Padding = new Padding(12);
            PanelMonedas.Size = new Size(282, 130);
            PanelMonedas.TabIndex = 6;
            // 
            // PanelDuracion
            // 
            PanelDuracion.BackColor = Color.Transparent;
            PanelDuracion.Location = new Point(942, 100);
            PanelDuracion.Name = "PanelDuracion";
            PanelDuracion.Padding = new Padding(12);
            PanelDuracion.Size = new Size(282, 130);
            PanelDuracion.TabIndex = 7;
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
            Size = new Size(1149, 1027);
            PanelDashboard.ResumeLayout(false);
            PanelDashboard.PerformLayout();
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
    }
}
