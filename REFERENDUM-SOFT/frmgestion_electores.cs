using System;
using System.Windows.Forms;
using REFERENDUM_SOFT.mysql;
using System.Data;
using PharmaSoft;


namespace REFERENDUM_SOFT
{
    public partial class frmgestion_electores : Form
    {
        public frmgestion_electores()
        {
            InitializeComponent();
        }

        int tipo_c = 0;
        int secc = 0;
        DataTable electores;

        private void frmgestion_electores_Load(object sender, EventArgs e)
        {
            carga_secciones();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void buscar_datos_electores() {
            if (secc > 0)
            {
                if (tipo_c > 0)
                {
                    string cad = "select NUMERO,NOMBRE,DIRECCION,CVE_ELECTOR,EDAD,GENERO from nominales where seccion=" + secc + " and casilla=" + tipo_c + " order by numero;";
                    electores = conexion.get_tabla(cad);
                    carga_electores();
                }
            }
        }


        private void carga_electores() {
            if (dgvLista.Columns.Count > 0)
            {
                dgvLista.Columns.Clear();
            }
            dgvLista.DataSource = electores;

            if (dgvLista.Rows.Count > 0)
            {
                txtfiltrar.Enabled = true;
                dgvLista.Columns[0].Width = 70;
                dgvLista.Columns[1].Width = 250;
                dgvLista.Columns[4].Width = 60;
                dgvLista.Columns[5].Width = 60;

                dgvLista.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvLista.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvLista.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            else {
                txtfiltrar.Enabled = false;
                otros.mensajito("No se ha encontrado información con los datos de la casilla seleccionada... Revise de nuevo");
            }
        }

        private void cmbcasillas_SelectedValueChanged(object sender, EventArgs e)
        {
            secc = cmbSeccion.SelectedIndex + 1;
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
            if (txtfiltrar.Text!=txtfiltrar.Tag.ToString())
            {
                electores.DefaultView.RowFilter = $"nombre LIKE '{txtfiltrar.Text}%'";
            }         
        }

        private void rbtBasica_Click(object sender, EventArgs e)
        {
            tipo_c = Convert.ToInt32(rbtBasica.Tag.ToString());
            buscar_datos_electores();
        }

        private void rbtcontigua1_Click(object sender, EventArgs e)
        {
            tipo_c = Convert.ToInt32(rbtcontigua1.Tag.ToString());
            buscar_datos_electores();
        }

        private void rbtcontigua2_Click(object sender, EventArgs e)
        {
            tipo_c = Convert.ToInt32(rbtcontigua2.Tag.ToString());
            buscar_datos_electores();
        }
    }
}
