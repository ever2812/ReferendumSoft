using System;
using System.Windows.Forms;
using REFERENDUM_SOFT.mysql;
using System.Data;
using PharmaSoft;
using System.Drawing;

namespace REFERENDUM_SOFT
{
    public partial class frmgestion_afavor : Form
    {
        public frmgestion_afavor()
        {
            InitializeComponent();
        }

        int tipo_c = 0;
        int cass = 0;
        DataTable electores;
        DataTable lista_favor;

        private void frmgestion_electores_Load(object sender, EventArgs e)
        {
            carga_casillas();
        }

        private void carga_casillas() {
            string cad = "select casilla from casilla order by id;";
            DataTable casillas = conexion.get_tabla(cad);
            if (casillas.Rows.Count > 0) {
                foreach (DataRow fila in casillas.Rows) {
                    cmbcasillas.Items.Add(fila[0].ToString());
                }
            }
        }



        private void carga_a_favor1()
        {
            if (cass > 0)
            {
                if (tipo_c > 0)
                {
                    string cad = "select a.NUMERO,a.NOMBRE,a.DIRECCION,a.CVE_ELECTOR,a.EDAD,b.representante as REPRESENTANTE from nominales a, a_favor b where a.cve_elector=b.cve_elector and casilla=" + cass + " and tipo_casilla=" + tipo_c + " order by numero;";
                    electores = conexion.get_tabla(cad);
                    if (electores.Rows.Count > 0)
                    {
                        foreach (DataRow fila in electores.Rows) {
                            string sqp = "select nombre from nominales where cve_elector='" + fila[5] + "'";
                            lista_favor = conexion.get_tabla(sqp);
                            foreach (DataRow mifi in lista_favor.Rows) {
                                fila[5] = mifi[0];
                            }
                        }
                        dgvLista.DataSource = electores;
                        a_favor_casilla();
                        a_favor_general(txtTotalGeneral);
                        txtfiltroClave.Enabled = true;
                        txtfiltrar.Enabled = true;
                    }
                    else {
                        otros.mensajito("No se ha encontrado información con los datos de la casilla seleccionada... Revise de nuevo");
                        txtfiltrar.Enabled = false;
                        txtfiltroClave.Enabled = false;
                    }
                }
            }
        }
    


        private void cmbcasillas_SelectedValueChanged(object sender, EventArgs e)
        {
            this.cass = cmbcasillas.SelectedIndex + 1;
        }

        private void txtfiltrar_Enter(object sender, EventArgs e)
        {
            if (txtfiltrar.Text == txtfiltrar.Tag.ToString()) {
                txtfiltrar.Clear();
                txtfiltrar.ForeColor = Color.Black;
            }
        }

        private void txtfiltrar_Leave(object sender, EventArgs e)
        {
            if (txtfiltrar.Text == "") {
                txtfiltrar.Text = txtfiltrar.Tag.ToString();
                txtfiltrar.ForeColor = Color.Gray;
            }
        }

        private void txtfiltrar_TextChanged(object sender, EventArgs e)
        {
            if (txtfiltrar.Text!=txtfiltrar.Tag.ToString())
            {
                electores.DefaultView.RowFilter = $"nombre LIKE '{txtfiltrar.Text}%'";
            }    
        }

        private void rbtBasica_Click(object sender, EventArgs e)
        {
            tipo_c = Convert.ToInt32(rbtBasica.Tag.ToString());
            carga_a_favor1();
        }

        private void rbtcontigua1_Click(object sender, EventArgs e)
        {
            tipo_c = Convert.ToInt32(rbtcontigua1.Tag.ToString());
            carga_a_favor1();
        }

        private void rbtcontigua2_Click(object sender, EventArgs e)
        {
            tipo_c = Convert.ToInt32(rbtcontigua2.Tag.ToString());
            carga_a_favor1();
        }

        private void a_favor_casilla() {
            txtTotalCasilla.Text = dgvLista.Rows.Count.ToString();
        }

        public void a_favor_general(TextBox txt) {
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
            frmLista_electoresFavor le = new frmLista_electoresFavor();
            le.Show();
        }
    }
}
