using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace abarrotes
{
    public partial class inventario_ajustes : Form
    {
        public inventario_ajustes()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `productos` ", conn.conexion.Obtnerconexion());
            //MySqlDataReader leer = comando.ExecuteReader();
            //lv1.Items.Clear();

            //while (leer.Read())
            //{
            //ListViewItem lv1 = new ListViewItem(leer.GetInt32(0).ToString());
            //lv1.SubItems.Add(leer.GetInt32(1).ToString());
            //lv1.SubItems.Add(leer.GetInt32(2).ToString());
            //lv1.SubItems.Add(leer.GetInt32(3).ToString());
            //lv1.SubItems.Add(leer.GetInt32(4).ToString());
            //lv1.SubItems.AddRange(lv1.ToString);
            //}
            //leer.Close();
            //comando.Dispose();
            //conn.conexion.Obtnerconexion().Close();
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
             /*   ListViewItem inve = new ListViewItem(dr.[Descricpcion].ToString);
                inve.SubItems.Add(dr.[Existencia].ToString);
                inve.SubItems.Add(dr.[unidad].ToString);
                inve.SubItems.Add(dr.[precio_venta].ToString);
                inve.SubItems.Add(dr.[precio_compra].ToString);
                lv1.Items.Add(inve);*/
            }


        }

        private void rbfaltantes_CheckedChanged(object sender, EventArgs e)
        {
            MySqlCommand mostrar = new MySqlCommand("SELECT `existencias`,`unidad`,`descripcion`,`pven` FROM `productos` ORDER BY existencias ASC", conn.conexion.Obtnerconexion());
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = mostrar;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgt1.DataSource = tabla;

        }
    }
}
