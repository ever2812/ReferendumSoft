using System;
using System.Data;
using System.Windows.Forms;
using REFERENDUM_SOFT.mysql;
using PharmaSoft;


namespace REFERENDUM_SOFT
{
    public partial class frmLista_electoresRep : Form
    {
        public frmLista_electoresRep(DataGridView estedgv, TextBox tttl)
        {
            dgv1 = estedgv;
            totalito = tttl;
            InitializeComponent();
        }

   
        int secc = 0;
        int tipo_c = 0;       
        string cve_elec = "";
        DataTable electores;
        DataGridView dgv1;
        TextBox totalito;

        private void frmLista_electores_Load(object sender, EventArgs e)
        {
            carga_secciones();
        }

        private void carga_secciones()
        {
            string cad = "select seccion from seccion order by id;";
            DataTable casillas = conexion.get_tabla(cad);
            if (casillas.Rows.Count > 0)
            {
                foreach (DataRow fila in casillas.Rows)
                {
                    cmbcasillas.Items.Add(fila[0].ToString());
                }
            }
        }


        private void buscar_electores()
        {
            if (secc > 0)
            {
                if (tipo_c > 0)
                {
                   string cad = "select NUMERO,NOMBRE,DIRECCION,nominales.CVE_ELECTOR,EDAD,GENERO from nominales left outer join representante on nominales.cve_elector=representante.cve_elector where representante.cve_elector is null and nominales.seccion="+secc+" and nominales.casilla="+ tipo_c +" order by nominales.numero";
                    electores = conexion.get_tabla(cad);
                    carga_electores();
                }
            }
        }

        private void carga_electores()
        {
            if (dgvLista.Columns.Count > 0)
            {
                dgvLista.Columns.Clear();
            }

            dgvLista.DataSource = electores;

            if (dgvLista.Rows.Count > 0)
            {
                txtfiltroClave.Enabled = true;
                txtFiltroNombre.Enabled = true;
                dgvLista.Columns[0].Width = 70;
                dgvLista.Columns[1].Width = 250;
                dgvLista.Columns[2].Width = 200;
                dgvLista.Columns[3].Width = 160;
                dgvLista.Columns[4].Width = 50;
                dgvLista.Columns[5].Width = 70;
            }
            else
            {
                otros.mensajito("No se ha encontrado información con los datos de la casilla seleccionada... Revise de nuevo");
                txtfiltroClave.Enabled = false;
                txtFiltroNombre.Enabled = false;
            }
        }
         
        private void rbtBasica_Click_1(object sender, EventArgs e)
        {
            tipo_c = Convert.ToInt32(rbtBasica.Tag.ToString());
            buscar_electores();
        }

        private void rbtcontigua1_Click_1(object sender, EventArgs e)
        {
            tipo_c = Convert.ToInt32(rbtcontigua1.Tag.ToString());
            buscar_electores();
        }

        private void rbtcontigua2_Click_1(object sender, EventArgs e)
        {
            tipo_c = Convert.ToInt32(rbtcontigua2.Tag.ToString());
            buscar_electores();
        }

        private void cmbcasillas_SelectedValueChanged_1(object sender, EventArgs e)
        {
            secc = cmbcasillas.SelectedIndex + 1;
        }

        private void dgvLista_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLista.Rows.Count > 0) { 
                foreach (DataGridViewRow fila in dgvLista.SelectedRows) {          
                    txtnombre.Text = fila.Cells[1].Value.ToString();
                    cve_elec = fila.Cells[3].Value.ToString();
                }
            }
        }

        private void btnAgrega_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text != "" && txtdescripcion.Text != "")
            {
                string cad = "insert into representante values('" + cve_elec + "','" + txtdescripcion.Text + "')";
                if (conexion.ejecutar(cad))
                {
                    frmRepresentantes rp = new frmRepresentantes();
                    string cad2 = "select a.numero,a.seccion,a.casilla,c.SECCION,d.TIPO as CASILLA,a.NOMBRE,a.DIRECCION,b.CVE_ELECTOR,b.DESCRIPCION from nominales a, representante b, seccion c, casilla d where a.cve_elector=b.cve_elector and a.seccion=c.id and a.casilla=d.id order by a.seccion, a.casilla, a.numero;";
                    rp.carga_representantes(dgv1,totalito,cad2);
                    conexion.ejecutar("insert into a_favor(cve_elector,representante) values('"+cve_elec+ "','" + cve_elec + "')");
                    buscar_electores();
                    txtnombre.Clear();
                    txtdescripcion.Clear();                 
                }
            }
            else {
                otros.mensajito("Revise los datos a ingresar e intente nuevamente...");
            }
        }

        private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtFiltroNombre_Enter(object sender, EventArgs e)
        {
            otros.efecto_enter(txtFiltroNombre);
        }

        private void txtFiltroNombre_Leave(object sender, EventArgs e)
        {
            otros.efecto_leave(txtFiltroNombre);
        }

        private void txtfiltroClave_Enter(object sender, EventArgs e)
        {
            otros.efecto_enter(txtfiltroClave);
        }

        private void txtfiltroClave_Leave(object sender, EventArgs e)
        {
            otros.efecto_leave(txtfiltroClave);
        }

        private void txtFiltroNombre_TextChanged(object sender, EventArgs e)
        {     
                if (txtFiltroNombre.Text != txtFiltroNombre.Tag.ToString() && txtFiltroNombre.Text!=" ")
                {
                    electores.DefaultView.RowFilter = $"nombre LIKE '{txtFiltroNombre.Text}%'";
                }
        }

        private void txtfiltroClave_TextChanged(object sender, EventArgs e)
        {
                if (txtfiltroClave.Text != txtfiltroClave.Tag.ToString() && txtfiltroClave.Text!=" ")
                {
                    electores.DefaultView.RowFilter = $"cve_elector LIKE '{txtfiltroClave.Text}%'";
                } 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}