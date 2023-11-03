using System;
using System.Windows.Forms;
using REFERENDUM_SOFT.mysql;
using System.Data;
using PharmaSoft;

namespace REFERENDUM_SOFT
{
    public partial class frmRepresentantes : Form
    {
        public frmRepresentantes()
        {
            InitializeComponent();
        }

        int tipo_c = 0;
        int secc = 0;
        DataTable representantes;
        public int total = 0;

        private void frmgestion_electores_Load(object sender, EventArgs e)
        {
            carga_secciones();
            todos_representantes();  
        }

        private void todos_representantes() {
            string cad = "select a.numero,a.seccion,a.casilla,c.SECCION as SECCION,d.TIPO as CASILLA,a.NOMBRE,a.DIRECCION,b.CVE_ELECTOR,b.DESCRIPCION from nominales a, representante b, seccion c, casilla d where a.cve_elector=b.cve_elector and a.seccion=c.id and a.casilla=d.id order by a.seccion, a.casilla, a.numero;";
            carga_representantes(dgvLista, txtTotalGeneral, cad);
        }


        private void carga_secciones() {
            string cad = "select seccion from seccion order by id;";
            DataTable casillas = conexion.get_tabla(cad);
            if (casillas.Rows.Count > 0) {
                foreach (DataRow fila in casillas.Rows) {
                    cmbSeccion.Items.Add(fila[0].ToString());
                }
            }
        }


        private void representantes_casillas(int tipo_cass) {
            if (secc > 0)
            {
                string cad = "select a.numero,a.seccion,a.casilla,c.SECCION,d.TIPO as CASILLA,a.NOMBRE,a.DIRECCION,b.CVE_ELECTOR,b.DESCRIPCION from nominales a, representante b, seccion c, casilla d where a.seccion=" + secc + " and a.casilla=" + tipo_cass + " and a.cve_elector=b.cve_elector and a.seccion=c.id and a.casilla=d.id order by a.seccion, a.casilla, a.numero;";
                carga_representantes(dgvLista, txtTotalGeneral, cad);
            }
            else {
                otros.mensajito("Debe elegir una sección de la lista desplegable... Intente de nuevo.");
            }
        }


        public void carga_representantes(DataGridView dgv, TextBox cajita, string consulta) {
            //string cad = "select a.numero,a.casilla,a.tipo_casilla,c.CASILLA,d.TIPO,a.NOMBRE,a.DIRECCION,b.CVE_ELECTOR,b.DESCRIPCION from nominales a, representante b, casilla c, tipo_casilla d where a.cve_elector=b.cve_elector and a.casilla=c.id and a.tipo_casilla=d.id order by a.casilla, a.tipo_casilla, a.numero;";
            representantes = conexion.get_tabla(consulta);         
            if (representantes.Rows.Count >= 0)
            {
                cajita.Text = representantes.Rows.Count.ToString();
                dgv.DataSource = representantes;
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].Visible = false;
                dgv.Columns[2].Visible = false;
                dgv.Columns[3].Width = 70;
                dgv.Columns[4].Width = 60;
                dgv.Columns[5].Width = 250;
                dgv.Columns[6].Width = 300;
                dgv.Columns[7].Width = 150;
            }
        }

        private void cmbcasillas_SelectedValueChanged(object sender, EventArgs e)
        {
            this.secc = cmbSeccion.SelectedIndex + 1;
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
            tipo_c = Convert.ToInt32(rbtBasica.Tag.ToString());
            representantes_casillas(tipo_c);    
        }

        private void rbtcontigua1_Click(object sender, EventArgs e)
        {
            tipo_c = Convert.ToInt32(rbtcontigua1.Tag.ToString());
            representantes_casillas(tipo_c);
        }

        private void rbtcontigua2_Click(object sender, EventArgs e)
        {
            tipo_c = Convert.ToInt32(rbtcontigua2.Tag.ToString());
            representantes_casillas(tipo_c);
        }
      
        private void btnAgrega_Click(object sender, EventArgs e)
        {
            frmLista_electoresRep le = new frmLista_electoresRep(dgvLista, txtTotalGeneral);
            le.Show();
        }

        private void rbtTodos_Click(object sender, EventArgs e)
        {
            todos_representantes();
            secc = 0;
        }
    }
}
