using System;
using System.Windows.Forms;
using REFERENDUM_SOFT.mysql;
using System.Data;
using PharmaSoft;
using System.Drawing.Printing;

namespace REFERENDUM_SOFT
{
    public partial class frmVotantes_Rep : Form
    {
        public frmVotantes_Rep()
        {
            InitializeComponent();
        }

     
        DataTable representantes;
        public int total = 0;

        private void frmgestion_electores_Load(object sender, EventArgs e)
        {
            carga_representantes();
            
        }

      
        private void carga_representantes()
        {
            string cad = "select a.cve_elector,b.NOMBRE from representante a, nominales b where a.cve_elector=b.cve_elector";
            representantes = conexion.get_tabla(cad);
            if (representantes.Rows.Count >= 0)
            {                
              dgvListaRep.DataSource = representantes;
                dgvListaRep.Columns[0].Visible = false;
                txtTotalRepresentante.Text = dgvListaRep.Rows.Count.ToString();         
            }
        }

        private void representantes_casillas(int tipo_cass)
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
             
        }

        private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaRep.Rows.Count > 0) {
                foreach (DataGridViewRow mifi in dgvListaRep.SelectedRows) {
                    string claveel = mifi.Cells[0].Value.ToString();              
                    string cons = "select b.NOMBRE,a.CVE_ELECTOR from a_favor a, nominales b where a.representante='"+claveel+"' and a.cve_elector=b.cve_elector order by b.nombre";
                    DataTable lista_personas = conexion.get_tabla(cons);
                    if (lista_personas.Rows.Count > 0)
                        dgvListaPersonas.DataSource = lista_personas;
                    txtTotalPersonas.Text = dgvListaPersonas.Rows.Count.ToString();
                }
            }
        }


        private void lblImprimir_Click(object sender, EventArgs e)
        {
            // Allow the user to choose the page range he or she would
            // like to print.
            printDialog1.AllowSomePages = true;
            // Show the help button.
            printDialog1.ShowHelp = true;

            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();

            // If the result is OK then print the document.
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (dgvListaRep.Rows.Count > 0) {

                string rep = "";
                foreach (DataGridViewRow rp in dgvListaRep.SelectedRows) {
                    rep = rp.Cells[1].Value.ToString();
                }

                System.Drawing.Font printFont = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);
                e.Graphics.DrawString("REPRESENTANTE: "+rep, printFont, System.Drawing.Brushes.Black, 40, 20);

                if (dgvListaPersonas.Rows.Count > 0)
                {               
                    int posy = 50;
                    string pers = "";
                    foreach (DataGridViewRow persona in dgvListaPersonas.Rows) {
                        pers = persona.Cells[0].Value.ToString();
                      e.Graphics.DrawString(pers, printFont, System.Drawing.Brushes.Black, 40, posy);                      
                        posy += 20;
                    }
                }
            }
        }
    }
}
