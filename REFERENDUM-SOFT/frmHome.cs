using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace REFERENDUM_SOFT
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,int wMsg, int wParam, int iParam);


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            

        }

      
        private void abre_form(Form formu)
        {
            if (PanelContenedor.Controls.Count > 0)
            { PanelContenedor.Controls.RemoveAt(0); }

            formu.TopLevel = false;
            formu.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Add(formu);
            PanelContenedor.Tag = formu;
            formu.Show();
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            frmgestion_electores gel = new frmgestion_electores();
            abre_form(gel);
        }

        private void btnAfavor_Click(object sender, EventArgs e)
        {
           frmgestion_afavor gea = new frmgestion_afavor();
           abre_form(gea);
        }

        private void btnRepresentantes_Click(object sender, EventArgs e)
        {
            frmRepresentantes rp = new frmRepresentantes();
            abre_form(rp);
        }

        private void btnSlide_Click_1(object sender, EventArgs e)
        {
            if (MVertical.Width == 220)
            {
                MVertical.Width = 60;
            }
            else if (MVertical.Width == 60)
            {
                MVertical.Width = 220;
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (SubmenuReportes.Visible == false)
            {
                SubmenuReportes.Visible = true;
            }
            else
            {
                SubmenuReportes.Visible = false;

            }
        }

        private void Btitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void btnReporteRep_Click(object sender, EventArgs e)
        {
            frmVotantes_Rep rptr = new frmVotantes_Rep();
            abre_form(rptr);
        }

        private void btnreportes1_Click(object sender, EventArgs e)
        {
            frmVotantes_Rep vtpr = new frmVotantes_Rep();
            abre_form(vtpr);
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {

        }
    }
}
