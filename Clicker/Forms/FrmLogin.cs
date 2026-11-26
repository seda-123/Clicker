using Clicker;

namespace Clicker
{
    public partial class inici_sesio : Form
    {
        public inici_sesio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inici_sessio_Click(object sender, EventArgs e)
        {
            FormInicio inici = new FormInicio();

            inici.FormClosed += (s, args) => Application.Exit();

            inici.Show();

            this.Hide();
        }

        private void registrat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registre registro = new registre();

            registro.FormClosed += (s, args) => Application.Exit();

            registro.Show();

            this.Hide();
        }
    }
}