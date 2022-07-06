using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace abarrotes
{
    public partial class cliente : Form
    {
        public cliente()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            conn.conexion.Obtnerconexion();
            string nombre = cbxNombre.Text;
            string razon = txtRazonSocial.Text;
            string rfc = txtRFC.Text;
            string emailfactura = txtEmail1.Text;
            string email2 = txtEmail2.Text;
            string telefono1 = txttel1.Text;
            string telefono2 = txttel2.Text;

            string guardar = "INSERT INTO clientes VALUES ('"+cbxNombre.Text+"','"+txtRazonSocial.Text+"','"+txtRFC.Text+"','"+txtEmail1.Text+"','"+txttel1.Text+"');";
            MySqlCommand almacenar = new MySqlCommand(guardar,conn.conexion.Obtnerconexion());
            almacenar.ExecuteNonQuery();
            conn.conexion.Obtnerconexion();
        }
    }
}
