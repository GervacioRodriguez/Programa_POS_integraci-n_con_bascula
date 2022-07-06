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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ajustesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventario_ajustes inva = new inventario_ajustes();
            inva.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            venta vt = new venta();
            vt.Show();
        }

        private void catalogosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cataproductos ctp = new cataproductos();
            ctp.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cliente ctl = new cliente();
            ctl.TopLevel = false;
            panel_principal.Controls.Add(ctl);
            ctl.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cliente v_cliente = new cliente();
            
        }
    }
}
