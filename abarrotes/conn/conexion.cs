using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace abarrotes.conn
{
    public class conexion
    {

        public static MySqlConnection Obtnerconexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; port=3310; database=tienda; Uid=root;pwd=;"); //admin123
            conectar.Open();
            return (conectar);
        }

        public void Autocompletar(TextBox text)
        {
            //Obtnerconexion();
            string buscar = "SELECT * FROM productos";
            DataTable datos = new DataTable();
            AutoCompleteStringCollection listadatos = new AutoCompleteStringCollection();
            MySqlDataAdapter adaptador = new MySqlDataAdapter(buscar,Obtnerconexion()); 
            adaptador.Fill(datos);
            for (int i=0; i < datos.Rows.Count; i++)
            {
                listadatos.Add(datos.Rows[i]["descripcion"].ToString());
                
            }
        }

        public string existeproducto(string producto)
        {
            string existe = "";
            string buscar = "SELECT codbar FROM productos WHERE codbar=@producto";
            try 
            {
                MySqlCommand cmd = new MySqlCommand(buscar,conexion.Obtnerconexion());
                //cmd.Parameters.AddWithValue("@producto");
                conexion.Obtnerconexion().Open();
                
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conexion.Obtnerconexion().Close();
            }
            return existe;
        }


        /*
        public void Llenarcombo(ComboBox combo1)
        {
            string query = "SELECT `codcorto`, `cod_barras`, `descripcion`, `unidad`, `existencias`, `p_compra`, `p_venta`, `proveedor` FROM `productos` WHERE 'id' = 'id' ";
            MySqlCommand cmd = new MySqlCommand(query, conn.conexion.Obtener());
            //cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            combo1.ValueMember = "id";
            combo1.DisplayMember = "descripcion";
            combo1.DataSource = dt;

        }*/


        public void CargarProductos(DataGridView dgv)
        {

            try
            {
                MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT codbar,codcorto,unidad,descripcion,existencia,pc,pv,foto FROM producto ", Obtnerconexion());
                DataTable tablita = new DataTable();
                adaptador.Fill(tablita);
                dgv.DataSource = tablita;

            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo cargar datos: " + ex.ToString());
            }
        }
        /*
        public void llenarcombo(ComboBox llenar)
        {
            string prooo = "SELECT `id`, `codcorto`, `cod_barras`, `descripcion`, `unidad`, `existencias`, `pcom`, `pven`, `departamento`, `proveedor` FROM `productos`";
            MySqlCommand producto = new MySqlCommand(prooo,Obtnerconexion());
            MySqlDataReader dr = producto.ExecuteReader();
            while (dr.Read())
            {
                llenar.Items.Add(dr.GetString(1));

            }
            Obtnerconexion().Close();

        }*/
        


    }
}
