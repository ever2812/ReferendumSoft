using System;
using System.Data;
using System.Windows.Forms;
using REFERENDUM_SOFT.mysql;
using PharmaSoft;

namespace REFERENDUM_SOFT
{
    public partial class frmLista_electoresFavor : Form
    {
        public frmLista_electoresFavor(TextBox total)
        {
            ttl = total;
            InitializeComponent();
        }

        int tipo_c = 0;
        int secc = 0;
        string clave_elector;
        DataTable electores;
        TextBox ttl;

        private void frmLista_electores_Load(object sender, EventArgs e)
        {
            carga_casillas();
        }

        private void carga_casillas()
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
                    limp(); 
                    string cad2 ="select NUMERO,NOMBRE,DIRECCION,nominales.CVE_ELECTOR,EDAD,GENERO from nominales left outer join a_favor on nominales.cve_elector=a_favor.cve_elector where a_favor.cve_elector is null and nominales.seccion=" + secc + " and nominales.casilla=" + tipo_c + " order by nominales.numero";
                    electores = conexion.get_tabla(cad2);
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

        private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvLista_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {            
                foreach (DataGridViewRow fila in dgvLista.SelectedRows)
                {
                txtelector.Text = fila.Cells[1].Value.ToString();
                txtelector.ForeColor = System.Drawing.Color.Black;             
                clave_elector = fila.Cells[3].Value.ToString();
                txtelector.Enabled = true;
                txtNombreRep.Enabled = true;
                txtClaveRep.Enabled = true;
            }
        }

        private void txtFiltroClave_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltroClave.Text != txtFiltroClave.Tag.ToString() && txtFiltroClave.Text != " ")
            {
                electores.DefaultView.RowFilter = $"cve_elector LIKE '{txtFiltroClave.Text}%'";
            }
        }

        private void txtFiltroNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltroNombre.Text != txtFiltroNombre.Tag.ToString() && txtFiltroNombre.Text != " ")
            {
                electores.DefaultView.RowFilter = $"nombre LIKE '{txtFiltroNombre.Text}%'";
            }
        }

        private void txtFiltroClave_Leave(object sender, EventArgs e)
        {
            otros.efecto_leave(txtFiltroClave);
        }

        private void txtFiltroClave_Enter(object sender, EventArgs e)
        {
            otros.efecto_enter(txtFiltroClave);
        }

        private void txtFiltroNombre_Enter(object sender, EventArgs e)
        {
            otros.efecto_enter(txtFiltroNombre);
        }

        private void txtFiltroNombre_Leave(object sender, EventArgs e)
        {
            otros.efecto_leave(txtFiltroNombre);
        }

        private void txtClaveRep_Enter(object sender, EventArgs e)
        {
            otros.efecto_enter(txtClaveRep);
        }

        private void txtClaveRep_Leave(object sender, EventArgs e)
        {
            otros.efecto_leave(txtClaveRep);
        }

        private void txtNombreRep_Leave(object sender, EventArgs e)
        {
            otros.efecto_leave(txtNombreRep);
        }

        private void txtNombreRep_Enter(object sender, EventArgs e)
        {
            otros.efecto_enter(txtNombreRep);
        }

        private void limp()
        {
            txtNombreRep.Text = txtNombreRep.Tag.ToString();
            txtelector.Text = txtelector.Tag.ToString();
            txtClaveRep.Text = txtClaveRep.Tag.ToString();
            txtNombreRep.Enabled = false;
            txtelector.Enabled = false;
            txtClaveRep.Enabled = false;
            clave_elector = "";
            lblvalida.Text = "0";
          
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (txtClaveRep.Text != txtClaveRep.Tag.ToString() && txtClaveRep.Text.Length == 18)
            {
                string cad = "select a.nombre from nominales a, representante b where b.cve_elector='"+txtClaveRep.Text+"' and a.cve_elector=b.cve_elector";
                DataTable busca = conexion.get_tabla(cad);
                if (busca.Rows.Count > 0)
                {
                    foreach (DataRow mifi in busca.Rows) {
                        txtNombreRep.Text = mifi[0].ToString();
                        lblvalida.Text = "1";
                    }
                }
                else {
                    otros.mensajito("Los datos no pertenecen a un representante, se debe agregar o corrija la información... ");
                }

            }
            else if (txtNombreRep.Text != txtNombreRep.Tag.ToString() && txtNombreRep.Text != "")
            {
                string cad = "select a.cve_elector from nominales a, representante b where a.nombre='" + txtNombreRep.Text + "' and a.cve_elector=b.cve_elector";
                DataTable busca = conexion.get_tabla(cad);
                if (busca.Rows.Count > 0)
                {
                    foreach (DataRow mifi in busca.Rows)
                    {
                        txtClaveRep.Text = mifi[0].ToString();
                        lblvalida.Text = "1";
                    }
                }
                else
                {
                    otros.mensajito("Los datos no pertenecen a un representante, se debe agregar o corrija la información... ");
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (txtelector.Text!=txtelector.Tag.ToString() && txtelector.Text!="")
            {
                frmEligeRepresentante erp = new frmEligeRepresentante(txtClaveRep, txtNombreRep, lblvalida);
                erp.Show();
            }
            else {
                otros.mensajito("Debe elegir primero el nombre de la persona para poder asignarle un representante...");
            }
        }

        private void btnAgrega_Click(object sender, EventArgs e)
        {
            if (clave_elector != "" && lblvalida.Text == "1")
            {
                string cad = "insert into a_favor values('" + clave_elector + "','" + txtClaveRep.Text + "')";
                
                if (conexion.ejecutar(cad))
                {
                    limp();
                    buscar_electores();
                    frmgestion_afavor.a_favor_general(ttl);
                    otros.mensajito("Agregado a favor...");
                }
            }
            else {
                otros.mensajito("Verifique los datos...");
            }
        }
    }
}