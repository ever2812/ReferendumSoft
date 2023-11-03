using System;
using System.Drawing;
using System.Windows.Forms;

namespace PharmaSoft
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == txtuser.Tag.ToString()) {
                txtuser.Clear();
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "") {
                txtuser.Text = txtuser.Tag.ToString();
                txtuser.ForeColor = Color.Gray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == txtpass.Tag.ToString()) {
                txtpass.Clear();
                txtpass.ForeColor = Color.Black;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "") {
                txtpass.Text = txtpass.Tag.ToString();
                txtpass.ForeColor = Color.Gray;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
