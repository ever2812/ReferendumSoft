using System;
using System.Windows.Forms;
using REFERENDUM_SOFT.mysql;
using System.Data;
using PharmaSoft;
using System.Drawing;

namespace REFERENDUM_SOFT
{
    public partial class frmEligeRepresentante : Form
    {
        public frmEligeRepresentante(TextBox cve_rep, TextBox nombre_rep,Label valida_)
        {
            clave_rep = cve_rep;
            name_rep = nombre_rep;
            bandera = valida_;
            InitializeComponent();
        }


        DataTable representantes;
        public int total = 0;
        TextBox clave_rep, name_rep;
        Label bandera;

        private void frmgestion_electores_Load(object sender, EventArgs e)
        {
           carga_representantes(dgvLista);          
        }

      
         public void carga_representantes(DataGridView dgv) {
            string cad = "select a.numero,a.seccion,a.casilla,c.SECCION,d.TIPO,a.NOMBRE,a.DIRECCION,b.CVE_ELECTOR,b.DESCRIPCION from nominales a, representante b, seccion c, casilla d where a.cve_elector=b.cve_elector and a.seccion=c.id and a.casilla=d.id order by a.seccion, a.casilla, a.numero;";
            representantes = conexion.get_tabla(cad);         
            if (representantes.Rows.Count >= 0)
            {
                dgv.DataSource = representantes;
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].Visible = false;
                dgv.Columns[2].Visible = false;
                dgv.Columns[3].Width = 60;
                dgv.Columns[4].Width = 60;
                dgv.Columns[6].Width = 300;
                dgv.Columns[7].Width = 150;
            }
        }

        private void cmbcasillas_SelectedValueChanged(object sender, EventArgs e)
        {
 
        }

        private void txtfiltrar_Enter(object sender, EventArgs e)
        {
            otros.efecto_enter(txtfiltrar);
        }

        private void txtfiltrar_Leave(object sender, EventArgs e)
        {
            otros.efecto_leave(txtfiltrar);
        }

        private void txtfiltrar_TextChanged(object sender, EventArgs e)
        {
            if (txtfiltrar.Text!=txtfiltrar.Tag.ToString() && txtfiltrar.Text!=" ")
            {
               representantes.DefaultView.RowFilter = $"nombre LIKE '{txtfiltrar.Text}%'";
            }    
        }

        private void rbtBasica_Click(object sender, EventArgs e)
        {
                   
        }

        private void rbtcontigua1_Click(object sender, EventArgs e)
        {
                   
        }

        private void rbtcontigua2_Click(object sender, EventArgs e)
        {
                   
        }

        private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow mifi in dgvLista.SelectedRows) {
                name_rep.Text = mifi.Cells[5].Value.ToString();
                clave_rep.Text = mifi.Cells[7].Value.ToString();
                bandera.Text = "1";
                clave_rep.ForeColor = Color.Black;
                name_rep.ForeColor = Color.Black;
               this.Close();
            }
        }

        private void btnAgrega_Click(object sender, EventArgs e)
        {
           
        }
    }
}
