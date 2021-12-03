using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace abarrotes.conn
{
    public class disenoGV
        {
            public void fondo(DataGridView color_fondo)
        {
            //diseno de anchura den datagrid
            color_fondo.Anchor = AnchorStyles.Top;
            color_fondo.Anchor = AnchorStyles.Bottom;
            color_fondo.Anchor = AnchorStyles.Left;
            color_fondo.Anchor = AnchorStyles.Right;

            //diseño de color del datagrid
            color_fondo.RowHeadersDefaultCellStyle.BackColor = Color.Blue;
            color_fondo.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            color_fondo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//selecciona toda la fila
            color_fondo.BorderStyle = BorderStyle.None;
            //color_fondo.BackgroundColor = Color.Transparent;

            //diseño de 
        }

        }
}
