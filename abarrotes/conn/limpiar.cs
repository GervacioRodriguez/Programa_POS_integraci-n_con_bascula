using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abarrotes.conn
{
    class limpiar
    {
        public void borrarcampos(Control control,GroupBox grb )
        {
            foreach (var txt in control.Controls)
            { 
                if (txt is TextBox) 
                { 
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedIndex = 0;
                }
            }
            foreach (var combo in grb.Controls)
            {
                if (combo is TextBox)
                {
                    ((TextBox)combo).Clear();
                }
                else if (combo is ComboBox)
                {
                    ((ComboBox)combo).SelectedIndex = 0;
                }
            }
        }

    }
}
