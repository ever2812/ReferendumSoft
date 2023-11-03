using System;
using System.Data;
using System.Windows.Forms;
using REFERENDUM_SOFT.mysql;
using PharmaSoft;

namespace REFERENDUM_SOFT
{
    public partial class frmLista_electores : Form
    {
        public frmLista_electores()
        {
            InitializeComponent();
        }

        int tipo_c = 0;
        int cass = 0;
        DataTable electores;

        private void frmLista_electores_Load(object sender, EventArgs e)
        {
            carga_casillas();
        }

        private void carga_casillas()
        {
            string cad = "select casilla from casilla order by id;";
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
            if (cass > 0)
            {
                if (tipo_c > 0)
                {
                    string cad = "select NUMERO,NOMBRE,DIRECCION,CVE_ELECTOR,EDAD,GENERO from nominales where a_favor<>'SI' and casilla=" + cass + " and tipo_casilla=" + tipo_c + " order by numero;";
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
            cass = cmbcasillas.SelectedIndex + 1;
        }
    }
}