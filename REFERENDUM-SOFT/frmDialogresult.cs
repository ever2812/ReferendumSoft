using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PharmaSoft
{
    public partial class frmDialogresult : Form
    {
        public frmDialogresult()
        {
            InitializeComponent();
        }

        string mostrar;
        public frmDialogresult(string mensaje) {
            mostrar = mensaje;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void frmDialogresult_Load(object sender, EventArgs e)
        {
            lblmensaje.Text = mostrar.ToUpper();
        }
    }
}
