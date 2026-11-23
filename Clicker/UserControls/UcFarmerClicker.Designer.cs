namespace Clicker.UserControls
{
    partial class UcFarmerClicker
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
            PanelFarmer = new Panel();
            SuspendLayout();
            // 
            // PanelFarmer
            // 
            PanelFarmer.Dock = DockStyle.Fill;
            PanelFarmer.Location = new Point(0, 0);
            PanelFarmer.Name = "PanelFarmer";
            PanelFarmer.Size = new Size(1776, 1118);
            PanelFarmer.TabIndex = 0;
            // 
            // UcFarmerClicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelFarmer);
            Name = "UcFarmerClicker";
            Size = new Size(1776, 1118);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelFarmer;
    }
}
