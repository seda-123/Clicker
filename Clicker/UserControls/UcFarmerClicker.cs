using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clicker.UserControls
{
    public partial class UcFarmerClicker : UserControl
    {
        int dinersInicial = 0;
        int dinersSegona = 0;
       

        public UcFarmerClicker()
        {
            InitializeComponent();
            vardiner.Text = $"{dinersInicial}€";
            variableDinero.Text = $"{dinersInicial}€";
            SegonaMilloraDiners.Text = $"{dinersSegona}€";
            maxMoney.Text = $"{dinersSegona}+";



        }

        private void titolTarjetaFarmer_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void descripcioJoc_Click(object sender, EventArgs e)
        {

        }

        private void PanelFarmer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void variablediner_Click(object sender, EventArgs e)
        {
           
        }
    }
}
