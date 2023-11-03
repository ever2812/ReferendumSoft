using System.Globalization;
using System.Windows.Forms;
using System;
using System.Drawing;

namespace PharmaSoft
{
    class otros
    {

        public static void mensajito(string mensaje) {
            frmAviso av = new frmAviso(mensaje);
            av.Show();
        }

        public static bool revisa(Panel contenedor)
        {
            bool respuesta = true;
            for (int i = 0; i < contenedor.Controls.Count; i++)
            {
                try
                {
                    TextBox txt = (TextBox)contenedor.Controls[i];
                    if (txt.Text == "")
                    {
                        //aplicar el cambio de color de fondo del textobx
                        txt.BackColor = System.Drawing.Color.Yellow;
                        respuesta = false;
                    }
                    else
                    {
                        txt.BackColor = System.Drawing.SystemColors.Window;
                    }
                }
                catch
                {

                }
            }
            if (respuesta == false)
            {
                //MessageBox.Show("Revise los campos marcados...");
            }
            return respuesta;
        }

        public static void limpiar(Panel contenedor)
        {
            for (int i = 0; i < contenedor.Controls.Count; i++)
            {
                try {
                    if (contenedor.Controls[i].Tag.ToString().Length > 0)
                    {
                        contenedor.Controls[i].Text = "";
                        contenedor.Controls[i].BackColor = System.Drawing.SystemColors.Window;
                    }
                }
                
                catch{}
                //try
                //{
                //    TextBox texto = (TextBox)contenedor.Controls[i];
                //    texto.Text = "";
                //    texto.BackColor = System.Drawing.SystemColors.Window;
                //}
                //catch { }
            }
        }

        public static string  tipo_moneda(decimal monto) {

            string cantidad = "";
            if (monto >= 1000)
            {
                cantidad = monto.ToString("0,000.00", CultureInfo.CurrentCulture);
            }
            else if (monto > 100)
            {
                cantidad = monto.ToString("000.00", CultureInfo.CurrentCulture);
            }
            else if (monto > 10)
            {
               cantidad= monto.ToString("00.00", CultureInfo.CurrentCulture);
            }
            else
            {
                cantidad = monto.ToString("0.00", CultureInfo.CurrentCulture);
            }

            return cantidad;
        }

       public  static void decimales(object sender, KeyPressEventArgs e)
        {
            try
            {
                CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
                if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                    e.Handled = false;
                else if (e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
                    if (((TextBox)sender).Text.Contains("."))
                        e.Handled = true;
                    else
                        e.Handled = false;
                else
                    e.Handled = true;
            }
            catch
            {
                MessageBox.Show(sender.GetType().ToString());
            }

        }

        static void enteros(object sender, KeyPressEventArgs e)
        {
            try
            {
                CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
                if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            catch
            {
                MessageBox.Show(sender.GetType().ToString());
            }
        }

        static void texto_varchar(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }

        public static string fecha_consulta(DateTime fecha) {

            string fh = fecha.Month.ToString() + "/" + fecha.Day.ToString() + "/" + fecha.Year.ToString();
            return fh;
        }

        public static void efecto_enter(TextBox caja_texto) {
            if (caja_texto.Text == caja_texto.Tag.ToString())
            {
                caja_texto.Clear();
                caja_texto.ForeColor = Color.Black;
            }
        }

        public static void efecto_leave(TextBox cajita_2) {
            if (cajita_2.Text == "")
            {
                cajita_2.Text = cajita_2.Tag.ToString();
                cajita_2.ForeColor = Color.Gray;
            }
        }

    }
}
