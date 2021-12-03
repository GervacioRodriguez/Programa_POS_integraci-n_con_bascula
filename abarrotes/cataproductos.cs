using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abarrotes
{
    public partial class cataproductos : Form
    {
        public cataproductos()
        {
            InitializeComponent();
               
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            MemoryStream msb = new MemoryStream();
            pb1.Image.Save(msb,ImageFormat.Jpeg);
            byte[] aByte = msb.ToArray();
            string query =
                "INSERT INTO producto" +
                " (codbar,codcorto,unidad,descripcion,existencia,pc,pv,foto)" +
                " VALUES " +
                "('"+txtcodigobarras.Text+"','"+txtcodigocorto.Text+"','"+txtunidad.Text+"','"+txtdescproducto.Text+"','"+txtexistencias.Text+"','"+txtprecompra.Text+"','"+txtpreventa.Text+"',@foto);";//"';"

            MySqlCommand guardar = new MySqlCommand (query, conn.conexion.Obtnerconexion());
            guardar.Parameters.AddWithValue("foto",aByte);
            guardar.ExecuteNonQuery();//guardas
            MessageBox.Show("Se ha guardado el producto:  "+txtdescproducto.Text);
            pb1.Image = null;

            conn.limpiar limpiar = new conn.limpiar();
            limpiar.borrarcampos(this,groupBox1);

            conn.conexion carga = new conn.conexion();
            carga.CargarProductos(dgtproducto);

            conn.conexion.Obtnerconexion().Close();

        }

        private void cataproductos_Load(object sender, EventArgs e)
        {
            // btnguardar.Enabled = false;
            conn.conexion carga = new conn.conexion();
            carga.CargarProductos(dgtproducto);

            conn.disenoGV lolo = new conn.disenoGV();
            lolo.fondo(dgtproducto);
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {

            string id = txtdescproducto.Text;
            MySqlDataReader leer = null;
            string actualizar = "UPDATE `productos` SET codcorto= '" + txtcodigocorto.Text +
                "'cod_barras ='" + txtcodigobarras.Text +
                "'descripcion ='" + txtdescproducto.Text +
                "'unidad ='" + txtunidad.Text +
                "'existencias ='" + txtexistencias.Text +
                "'pcom ='" + txtprecompra.Text +
                "'pven ='" + txtpreventa.Text +
                "'WHERE descripcion='" + id +
                "';";
            ;
            conn.conexion.Obtnerconexion().Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(actualizar, conn.conexion.Obtnerconexion());
                leer = comando.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        txtcodigobarras.Text = leer.GetString(2);
                        txtcodigocorto.Text = leer.GetString(1);
                        txtdescproducto.Text = leer.GetString(3);
                        txtunidad.Text = leer.GetString(4);
                        txtexistencias.Text = leer.GetString(5);
                        txtprecompra.Text = leer.GetString(6);
                        txtpreventa.Text = leer.GetString(7);
                        
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar" + ex);
            }
            conn.conexion carga = new conn.conexion();
            carga.CargarProductos(dgtproducto);

        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            string id = txtcodigobarras.Text;
            MySqlDataReader leer = null;
            string query = "SELECT `codcorto`, `cod_barras`, `descripcion`, `unidad`, `existencias`, `pcom`, `pven`, `departamento`, `proveedor FROM `productos` WHERE descripcion LIKE '" + id + "' LIMIT 1";
            conn.conexion.Obtnerconexion().Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(query, conn.conexion.Obtnerconexion());
                leer = comando.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        txtcodigobarras.Text = leer.GetString(2);
                        txtcodigocorto.Text = leer.GetString(1);
                        txtdescproducto.Text = leer.GetString(3);
                        txtunidad.Text = leer.GetString(4);
                        txtexistencias.Text = leer.GetString(5);
                        txtprecompra.Text = leer.GetString(6);
                        txtpreventa.Text = leer.GetString(7);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar" + ex);
            }
            conn.conexion carga = new conn.conexion();
            carga.CargarProductos(dgtproducto);

        }

        private void txtcodigobarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataTable datos = new DataTable();
            string buscar = "SELECT * FROM productos";
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            MySqlDataAdapter adaptador = new MySqlDataAdapter(buscar,conn.conexion.Obtnerconexion());
            adaptador.Fill(datos);

            for (int i=0; i < datos.Rows.Count; i++)
            {
                lista.Add(datos.Rows[i]["descripcion"].ToString());
            }
            txtdescproducto.AutoCompleteCustomSource = lista;
        }

        private void dgt1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            
                txtcodigobarras.Text = dgtproducto.CurrentRow.Cells[0].Value.ToString();
                txtcodigocorto.Text = dgtproducto.CurrentRow.Cells[1].Value.ToString();
                txtunidad.Text = dgtproducto.CurrentRow.Cells[2].Value.ToString();
                txtdescproducto.Text = dgtproducto.CurrentRow.Cells[3].Value.ToString();
                txtexistencias.Text = dgtproducto.CurrentRow.Cells[4].Value.ToString();
                txtprecompra.Text = dgtproducto.CurrentRow.Cells[5].Value.ToString();
                txtpreventa.Text = dgtproducto.CurrentRow.Cells[6].Value.ToString();
                
               
            }
            catch
            {

            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            conn.conexion.Obtnerconexion();
            string actualizar = "UPDATE productos SET codcorto= '" + txtcodigocorto.Text +
                "',codbar ='" + txtcodigobarras.Text +
                "',descripcion ='" + txtdescproducto.Text +
                "',unidad ='" + txtunidad.Text +
                "',existencias ='" + txtexistencias.Text +
                "',preciocompra ='" + txtprecompra.Text +
                "',precioventa ='" + txtpreventa.Text +
                "'WHERE id ='" + txtcodigobarras.Text +
                "';";
            MySqlCommand comando = new MySqlCommand(actualizar,conn.conexion.Obtnerconexion());
            comando.ExecuteNonQuery();
            conn.limpiar limpiar = new conn.limpiar();
            limpiar.borrarcampos(this, groupBox1);
            conn.conexion.Obtnerconexion().Close();
            MessageBox.Show("Se actualizo correctamente");
            conn.conexion.Obtnerconexion().Close();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            conn.conexion.Obtnerconexion();
            string borrar = "DELETE FROM productos WHERE codbar='"+txtcodigobarras.Text+"';";
            MySqlCommand comando = new MySqlCommand(borrar,conn.conexion.Obtnerconexion());
            comando.ExecuteNonQuery();
            conn.limpiar limpiar = new conn.limpiar();
            limpiar.borrarcampos(this, groupBox1);
            conn.conexion.Obtnerconexion().Close();
            MessageBox.Show("Se ha eliminado con exito el prodiucto");
            conn.conexion.Obtnerconexion().Close();
        }
        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            conn.conexion.Obtnerconexion();
            string buscar = "SELECT * FROM productos WHERE descripcion like('" + txtbuscar.Text + "&')";
            MySqlCommand buscar_texbox = new MySqlCommand(buscar,conn.conexion.Obtnerconexion());

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(buscar_texbox);
            da.Fill(dt);
            dgtproducto.DataSource =dt;
            conn.conexion.Obtnerconexion().Close();
        }

        private void btnimagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            img.Filter = "imagenes | *.jpg; *.png;";
            img.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            img.Title = "Seleccionar una imagen";

            if (img.ShowDialog() == DialogResult.OK)
            {
                pb1.Image = Image.FromFile(img.FileName);
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            conn.conexion buscar = new conn.conexion();
            buscar.Autocompletar(this.txtbuscar);

            conn.conexion carga = new conn.conexion();
            carga.CargarProductos(dgtproducto);

            conn.conexion.Obtnerconexion().Close();

        }

        private void dgtproducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // txtcodigobarras.Text = dgtproducto.SelectedCells[0].Value
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            conn.limpiar limpiar = new conn.limpiar();
            limpiar.borrarcampos(this, groupBox1);
        }
    }
}
