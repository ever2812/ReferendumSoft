using System;
using System.Windows.Forms;
using REFERENDUM_SOFT.mysql;
using System.Data;
using PharmaSoft;

namespace REFERENDUM_SOFT
{
    public partial class frmgestion_afavor : Form
    {
        public frmgestion_afavor()
        {
            InitializeComponent();
        }

        int casilla = 0;
        int secc = 0;
        int bdn = 0;
        DataTable electores;
        DataTable lista_favor;
        
        private void frmgestion_electores_Load(object sender, EventArgs e)
        {
            carga_casillas();
        }

        private void carga_casillas() {
            string cad = "select seccion from seccion  order by id;";
            DataTable casillas = conexion.get_tabla(cad);
            if (casillas.Rows.Count > 0) {
                foreach (DataRow fila in casillas.Rows) {
                    cmbcasillas.Items.Add(fila[0].ToString());
                }
            }
        }

        private void carga_a_favor1()
        {
            string cad="";
            if (secc > 0)
            {
                if (casilla > 0)
                {
                     cad = "select a.NUMERO,a.NOMBRE,a.DIRECCION,a.CVE_ELECTOR,a.EDAD,b.representante as REPRESENTANTE from nominales a, a_favor b where a.cve_elector=b.cve_elector and a.seccion=" + secc + " and a.casilla=" + casilla + " order by numero;";     
                }
            }
            else if(secc==0) {
                cad = "select c.SECCION,d.TIPO,a.NUMERO,a.NOMBRE,a.DIRECCION,a.CVE_ELECTOR,a.EDAD,b.REPRESENTANTE from nominales a, a_favor b, seccion c, casilla d where a.cve_elector=b.cve_elector and a.seccion=c.id and a.casilla=d.id order by a.seccion, a.casilla, a.numero;";
            }

            if (bdn > 0) {
                electores.Rows.Clear();
                electores.Columns.Clear();
            }
            
            electores = conexion.get_tabla(cad);

            if (electores.Rows.Count > 0)
            {  
                foreach (DataRow fila in electores.Rows)
                {
                    string sqp="";
                    if (electores.Columns.Count > 6)
                    {
                         sqp = "select nombre from nominales where cve_elector='" + fila[7] + "'";
                    }
                    else {
                         sqp = "select nombre from nominales where cve_elector='" + fila[5] + "'";
                    }
                   
                    lista_favor = conexion.get_tabla(sqp);
                    foreach (DataRow mifi in lista_favor.Rows)
                    {
                        if (electores.Columns.Count > 6)
                        {
                            fila[7] = mifi[0];
                        }
                        else {
                            fila[5] = mifi[0];
                        }       
                    }
                }
                dgvLista.DataSource = electores;
                if (electores.Rows.Count > 0)
                {
                    if (electores.Columns.Count > 6)
                    {
                        dgvLista.Columns[0].Width = 70;
                        dgvLista.Columns[1].Width = 50;
                        dgvLista.Columns[2].Width = 70;
                        dgvLista.Columns[3].Width = 250;
                        dgvLista.Columns[6].Width = 50;
                    }
                    else {
                        dgvLista.Columns[0].Width = 70;
                        dgvLista.Columns[1].Width = 250;
                        dgvLista.Columns[2].Width = 300;
                        dgvLista.Columns[4].Width = 50;
                    }
                }
                a_favor_casilla();
                a_favor_general(txtTotalGeneral);
                txtfiltroClave.Enabled = true;
                txtFiltroNombre.Enabled = true;
                bdn += 1;
            }
            else
            {
                otros.mensajito("No se ha encontrado información con los datos de la casilla seleccionada... Revise de nuevo");
                txtFiltroNombre.Enabled = false;
                txtfiltroClave.Enabled = false;
                
            }
        }
    
        private void cmbcasillas_SelectedValueChanged(object sender, EventArgs e)
        {
            this.secc = cmbcasillas.SelectedIndex + 1;
        }

        private void txtfiltrar_Enter(object sender, EventArgs e)
        {
            otros.efecto_enter(txtFiltroNombre);
        }

        private void txtfiltrar_Leave(object sender, EventArgs e)
        {
            otros.efecto_leave(txtFiltroNombre);
        }

        private void txtfiltrar_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltroNombre.Text!=txtFiltroNombre.Tag.ToString())
            {
                electores.DefaultView.RowFilter = $"nombre LIKE '{txtFiltroNombre.Text}%'";
            }    
        }

        private void rbtBasica_Click(object sender, EventArgs e)
        {
            casilla = Convert.ToInt32(rbtBasica.Tag.ToString());
            carga_a_favor1();
        }

        private void rbtcontigua1_Click(object sender, EventArgs e)
        {
            casilla = Convert.ToInt32(rbtcontigua1.Tag.ToString());
            carga_a_favor1();
        }

        private void rbtcontigua2_Click(object sender, EventArgs e)
        {
            casilla = Convert.ToInt32(rbtcontigua2.Tag.ToString());
            carga_a_favor1();
        }

        private void a_favor_casilla() {
            txtTotalCasilla.Text = dgvLista.Rows.Count.ToString();
        }

        public static void a_favor_general(TextBox txt) {
            string cad = "select count(cve_elector) from a_favor";
            DataTable res1 = conexion.get_tabla(cad);        
            if (res1.Rows.Count > 0) {
                foreach (DataRow mifila in res1.Rows) {
                    txt.Text = mifila[0].ToString();
                }
                
            }         
        }

        private void btnAgrega_Click(object sender, EventArgs e)
        {
            frmLista_electoresFavor le = new frmLista_electoresFavor(txtTotalGeneral);
            le.Show();
        }

        private void txtfiltroClave_Enter(object sender, EventArgs e)
        {
            otros.efecto_enter(txtfiltroClave);
        }

        private void txtfiltroClave_Leave(object sender, EventArgs e)
        {
            otros.efecto_leave(txtfiltroClave);
        }

        private void txtfiltroClave_TextChanged(object sender, EventArgs e)
        {
            if (txtfiltroClave.Text != txtfiltroClave.Tag.ToString())
            {
                electores.DefaultView.RowFilter = $"cve_elector LIKE '{txtfiltroClave.Text}%'";
            }
        }

        private void rbtTodos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtTodos_Click(object sender, EventArgs e)
        {
            secc = 0;
            casilla = 0;
            carga_a_favor1();
        }
    }
}
