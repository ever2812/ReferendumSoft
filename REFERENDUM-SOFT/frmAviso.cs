using System;
using System.Windows.Forms;

namespace PharmaSoft
{
    public partial class frmAviso : Form
    {
        public frmAviso(string mensaje)
        {
            mostrar = mensaje;
            InitializeComponent();
        }


        string mostrar;
        private void frmAviso_Load(object sender, EventArgs e)
        {
            lblmensaje.Text = mostrar.ToUpper();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
