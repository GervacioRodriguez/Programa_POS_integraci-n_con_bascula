using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace abarrotes
{
    public partial class venta : Form
    {
        public venta()
        {
            InitializeComponent();
        }

        private void venta_Load(object sender, EventArgs e)
        {
            conn.conexion combo = new conn.conexion();
            //combo.llenarcombo(cmbproducto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem producto = new ListViewItem(cmbproducto.Text);
            producto.SubItems.Add(txtcant.Text);
            producto.SubItems.Add(txtunidad.Text);
            producto.SubItems.Add(txtimporte.Text);
            producto.SubItems.Add(txttotal.Text);
            listView1.Items.Add(producto);
        }





        
        
    }
}
