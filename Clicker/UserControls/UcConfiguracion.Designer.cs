namespace Clicker.UserControls
{
    partial class UcConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcConfiguracion));
            titol = new Label();
            LblDescripcion = new Label();
            datosTitol = new Label();
            DatosDesc = new Label();
            linea1 = new Label();
            label1 = new Label();
            PanelDatos = new Clicker.Controles.TarjetaDashboard();
            rolUsuari = new Label();
            idUsuari = new Label();
            contraUsuari = new Label();
            nomUsuari = new Label();
            id = new Label();
            rol = new Label();
            contra = new Label();
            Nom = new Label();
            tarjetaDashboard1 = new Clicker.Controles.TarjetaDashboard();
            CambiarContra = new Button();
            repitecontra = new Label();
            NovaContraseña = new Label();
            ContraAct = new Label();
            ContraActual = new TextBox();
            label3 = new Label();
            label2 = new Label();
            descCambiContra = new Label();
            cambiContra = new Label();
            ContraNueva = new TextBox();
            RepeatContraNueva = new TextBox();
            PanelDatos.SuspendLayout();
            tarjetaDashboard1.SuspendLayout();
            SuspendLayout();
            // 
            // titol
            // 
            titol.AutoSize = true;
            titol.Font = new Font("Comfortaa SemiBold", 14.25F, FontStyle.Bold);
            titol.ForeColor = Color.FromArgb(16, 24, 40);
            titol.Location = new Point(60, 25);
            titol.Name = "titol";
            titol.Size = new Size(155, 30);
            titol.TabIndex = 1;
            titol.Text = "Configuracion";
            // 
            // LblDescripcion
            // 
            LblDescripcion.AutoSize = true;
            LblDescripcion.Font = new Font("Comfortaa", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblDescripcion.ForeColor = Color.FromArgb(102, 112, 133);
            LblDescripcion.Location = new Point(60, 58);
            LblDescripcion.Name = "LblDescripcion";
            LblDescripcion.Size = new Size(400, 21);
            LblDescripcion.TabIndex = 2;
            LblDescripcion.Text = "Gestiona tu cuenta, perfil y preferencias de la aplicación.";
            // 
            // datosTitol
            // 
            datosTitol.AutoSize = true;
            datosTitol.Font = new Font("Comfortaa", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datosTitol.ForeColor = Color.FromArgb(102, 112, 133);
            datosTitol.Location = new Point(15, 21);
            datosTitol.Name = "datosTitol";
            datosTitol.Size = new Size(77, 21);
            datosTitol.TabIndex = 5;
            datosTitol.Text = "Tus Datos";
            // 
            // DatosDesc
            // 
            DatosDesc.AutoSize = true;
            DatosDesc.Font = new Font("Comfortaa", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DatosDesc.ForeColor = Color.FromArgb(152, 162, 179);
            DatosDesc.Location = new Point(21, 45);
            DatosDesc.Name = "DatosDesc";
            DatosDesc.Size = new Size(198, 18);
            DatosDesc.TabIndex = 6;
            DatosDesc.Text = "Información asociada a tu cuenta.";
            // 
            // linea1
            // 
            linea1.AutoSize = true;
            linea1.Font = new Font("Comfortaa", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linea1.ForeColor = Color.FromArgb(152, 162, 179);
            linea1.Location = new Point(13, 63);
            linea1.Name = "linea1";
            linea1.Size = new Size(1098, 18);
            linea1.TabIndex = 7;
            linea1.Text = resources.GetString("linea1.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 102);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 8;
            // 
            // PanelDatos
            // 
            PanelDatos.BackColor = Color.Transparent;
            PanelDatos.Controls.Add(rolUsuari);
            PanelDatos.Controls.Add(idUsuari);
            PanelDatos.Controls.Add(contraUsuari);
            PanelDatos.Controls.Add(nomUsuari);
            PanelDatos.Controls.Add(id);
            PanelDatos.Controls.Add(rol);
            PanelDatos.Controls.Add(contra);
            PanelDatos.Controls.Add(Nom);
            PanelDatos.Controls.Add(label1);
            PanelDatos.Controls.Add(linea1);
            PanelDatos.Controls.Add(DatosDesc);
            PanelDatos.Controls.Add(datosTitol);
            PanelDatos.Location = new Point(100, 111);
            PanelDatos.Name = "PanelDatos";
            PanelDatos.Padding = new Padding(12);
            PanelDatos.Size = new Size(1122, 447);
            PanelDatos.TabIndex = 3;
            // 
            // rolUsuari
            // 
            rolUsuari.AutoSize = true;
            rolUsuari.Font = new Font("Comfortaa", 8.249999F);
            rolUsuari.ForeColor = Color.FromArgb(152, 162, 179);
            rolUsuari.Location = new Point(91, 296);
            rolUsuari.Name = "rolUsuari";
            rolUsuari.Size = new Size(0, 18);
            rolUsuari.TabIndex = 17;
            // 
            // idUsuari
            // 
            idUsuari.AutoSize = true;
            idUsuari.Font = new Font("Comfortaa", 8.249999F);
            idUsuari.ForeColor = Color.FromArgb(152, 162, 179);
            idUsuari.Location = new Point(824, 296);
            idUsuari.Name = "idUsuari";
            idUsuari.Size = new Size(0, 18);
            idUsuari.TabIndex = 16;
            // 
            // contraUsuari
            // 
            contraUsuari.AutoSize = true;
            contraUsuari.Font = new Font("Comfortaa", 8.249999F);
            contraUsuari.ForeColor = Color.FromArgb(152, 162, 179);
            contraUsuari.Location = new Point(824, 147);
            contraUsuari.Name = "contraUsuari";
            contraUsuari.Size = new Size(0, 18);
            contraUsuari.TabIndex = 15;
            // 
            // nomUsuari
            // 
            nomUsuari.AutoSize = true;
            nomUsuari.Font = new Font("Comfortaa", 8.249999F);
            nomUsuari.ForeColor = Color.FromArgb(152, 162, 179);
            nomUsuari.Location = new Point(91, 147);
            nomUsuari.Name = "nomUsuari";
            nomUsuari.Size = new Size(0, 18);
            nomUsuari.TabIndex = 14;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Font = new Font("Comfortaa", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            id.ForeColor = Color.FromArgb(16, 24, 40);
            id.Location = new Point(744, 270);
            id.Name = "id";
            id.Size = new Size(21, 18);
            id.TabIndex = 13;
            id.Text = "id:";
            // 
            // rol
            // 
            rol.AutoSize = true;
            rol.Font = new Font("Comfortaa", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rol.ForeColor = Color.FromArgb(16, 24, 40);
            rol.Location = new Point(21, 270);
            rol.Name = "rol";
            rol.Size = new Size(25, 18);
            rol.TabIndex = 12;
            rol.Text = "rol:";
            // 
            // contra
            // 
            contra.AutoSize = true;
            contra.Font = new Font("Comfortaa", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contra.ForeColor = Color.FromArgb(16, 24, 40);
            contra.Location = new Point(744, 117);
            contra.Name = "contra";
            contra.Size = new Size(74, 18);
            contra.TabIndex = 11;
            contra.Text = "contraseña:";
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.Font = new Font("Comfortaa", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nom.ForeColor = Color.FromArgb(16, 24, 40);
            Nom.Location = new Point(21, 117);
            Nom.Name = "Nom";
            Nom.Size = new Size(56, 18);
            Nom.TabIndex = 9;
            Nom.Text = "Nombre:";
            // 
            // tarjetaDashboard1
            // 
            tarjetaDashboard1.BackColor = Color.Transparent;
            tarjetaDashboard1.Controls.Add(RepeatContraNueva);
            tarjetaDashboard1.Controls.Add(ContraNueva);
            tarjetaDashboard1.Controls.Add(CambiarContra);
            tarjetaDashboard1.Controls.Add(repitecontra);
            tarjetaDashboard1.Controls.Add(NovaContraseña);
            tarjetaDashboard1.Controls.Add(ContraAct);
            tarjetaDashboard1.Controls.Add(ContraActual);
            tarjetaDashboard1.Controls.Add(label3);
            tarjetaDashboard1.Controls.Add(label2);
            tarjetaDashboard1.Controls.Add(descCambiContra);
            tarjetaDashboard1.Controls.Add(cambiContra);
            tarjetaDashboard1.Location = new Point(100, 610);
            tarjetaDashboard1.Name = "tarjetaDashboard1";
            tarjetaDashboard1.Padding = new Padding(12);
            tarjetaDashboard1.Size = new Size(1122, 271);
            tarjetaDashboard1.TabIndex = 4;
            // 
            // CambiarContra
            // 
            CambiarContra.BackColor = Color.FromArgb(6, 23, 68);
            CambiarContra.Font = new Font("Comfortaa", 8.249999F);
            CambiarContra.ForeColor = Color.White;
            CambiarContra.Location = new Point(963, 221);
            CambiarContra.Name = "CambiarContra";
            CambiarContra.Size = new Size(133, 35);
            CambiarContra.TabIndex = 17;
            CambiarContra.Text = "Cambiar Contraseña";
            CambiarContra.UseVisualStyleBackColor = false;
            // 
            // repitecontra
            // 
            repitecontra.AutoSize = true;
            repitecontra.Font = new Font("Comfortaa", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            repitecontra.ForeColor = Color.FromArgb(16, 24, 40);
            repitecontra.Location = new Point(800, 106);
            repitecontra.Name = "repitecontra";
            repitecontra.Size = new Size(161, 18);
            repitecontra.TabIndex = 16;
            repitecontra.Text = "repite la nueva contraseña:";
            repitecontra.Click += label4_Click;
            // 
            // NovaContraseña
            // 
            NovaContraseña.AutoSize = true;
            NovaContraseña.Font = new Font("Comfortaa", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NovaContraseña.ForeColor = Color.FromArgb(16, 24, 40);
            NovaContraseña.Location = new Point(438, 106);
            NovaContraseña.Name = "NovaContraseña";
            NovaContraseña.Size = new Size(111, 18);
            NovaContraseña.TabIndex = 15;
            NovaContraseña.Text = "nueva contraseña:";
            // 
            // ContraAct
            // 
            ContraAct.AutoSize = true;
            ContraAct.Font = new Font("Comfortaa", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContraAct.ForeColor = Color.FromArgb(16, 24, 40);
            ContraAct.Location = new Point(91, 106);
            ContraAct.Name = "ContraAct";
            ContraAct.Size = new Size(112, 18);
            ContraAct.TabIndex = 14;
            ContraAct.Text = "contraseña actual:";
            // 
            // ContraActual
            // 
            ContraActual.Location = new Point(114, 137);
            ContraActual.Name = "ContraActual";
            ContraActual.Size = new Size(189, 23);
            ContraActual.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comfortaa", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(152, 162, 179);
            label3.Location = new Point(12, 183);
            label3.Name = "label3";
            label3.Size = new Size(1098, 18);
            label3.TabIndex = 10;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comfortaa", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(152, 162, 179);
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(1098, 18);
            label2.TabIndex = 9;
            label2.Text = resources.GetString("label2.Text");
            // 
            // descCambiContra
            // 
            descCambiContra.AutoSize = true;
            descCambiContra.Font = new Font("Comfortaa", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descCambiContra.ForeColor = Color.FromArgb(152, 162, 179);
            descCambiContra.Location = new Point(21, 36);
            descCambiContra.Name = "descCambiContra";
            descCambiContra.Size = new Size(324, 18);
            descCambiContra.TabIndex = 8;
            descCambiContra.Text = "Utiliza una contraseña segura de al menos 8 caracteres.";
            // 
            // cambiContra
            // 
            cambiContra.AutoSize = true;
            cambiContra.Font = new Font("Comfortaa", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cambiContra.ForeColor = Color.FromArgb(102, 112, 133);
            cambiContra.Location = new Point(15, 12);
            cambiContra.Name = "cambiContra";
            cambiContra.Size = new Size(168, 21);
            cambiContra.TabIndex = 7;
            cambiContra.Text = "cambio de contraseña ";
            // 
            // ContraNueva
            // 
            ContraNueva.Location = new Point(454, 137);
            ContraNueva.Name = "ContraNueva";
            ContraNueva.Size = new Size(189, 23);
            ContraNueva.TabIndex = 18;
            // 
            // RepeatContraNueva
            // 
            RepeatContraNueva.Location = new Point(863, 137);
            RepeatContraNueva.Name = "RepeatContraNueva";
            RepeatContraNueva.Size = new Size(189, 23);
            RepeatContraNueva.TabIndex = 19;
            // 
            // UcConfiguracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tarjetaDashboard1);
            Controls.Add(PanelDatos);
            Controls.Add(LblDescripcion);
            Controls.Add(titol);
            Name = "UcConfiguracion";
            Size = new Size(2258, 1268);
            PanelDatos.ResumeLayout(false);
            PanelDatos.PerformLayout();
            tarjetaDashboard1.ResumeLayout(false);
            tarjetaDashboard1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label titol;
        private Label LblDescripcion;
        private Label datosTitol;
        private Label DatosDesc;
        private Label linea1;
        private Label label1;
        private Controles.TarjetaDashboard PanelDatos;
        private Label contraUsuari;
        private Label nomUsuari;
        private Label id;
        private Label rol;
        private Label contra;
        private Label Nom;
        private Label rolUsuari;
        private Label idUsuari;
        private Controles.TarjetaDashboard tarjetaDashboard1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox ContraActual;
        private Label label3;
        private Label label2;
        private Label descCambiContra;
        private Label cambiContra;
        private Label repitecontra;
        private Label NovaContraseña;
        private Label ContraAct;
        private Button CambiarContra;
        private TextBox RepeatContraNueva;
        private TextBox ContraNueva;
    }
}
