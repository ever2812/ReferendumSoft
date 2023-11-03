using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;


namespace REFERENDUM_SOFT.mysql
{
    class conexion
    {


        public static MySqlConnection conectar()
        {
            MySqlConnection cnx = new MySqlConnection("server=127.0.0.1;database=gestion;Uid=root;pdw=;");
            return cnx;
        }


        public static bool ejecutar(string consulta)
        {
            MySqlConnection cn = conectar();
            MySqlCommand cmd1 = new MySqlCommand(consulta, cn);
            cn.Open();
            cmd1.CommandType = System.Data.CommandType.Text;
            cmd1.ExecuteNonQuery();
            cn.Close();
            return true;
        }

        public static DataTable get_tabla(string consulta)
        {
            DataTable mitbl = new DataTable();
            DataTable tbl2 = new DataTable();
            DataSet dts = new DataSet();
            MySqlConnection cn = conectar();
            MySqlDataAdapter dtp = new MySqlDataAdapter(consulta, cn);
            try
            {
                cn.Open();
                dtp.Fill(dts, "tabla1");
                cn.Close();
            }
            catch { }

            foreach (DataTable td in dts.Tables)
            {
                tbl2 = td;
            }

            return tbl2;
        }

    }
}
