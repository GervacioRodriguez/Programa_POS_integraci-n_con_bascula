using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace abarrotes.conn
{
    class productos
    {
        private int id;
        private string codigobarras;
        private string descripcion;
        private string codicorto;

        public int Id { get => id; set => id = value; }
        public string Codigobarras { get => codigobarras; set => codigobarras = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Codicorto { get => codicorto; set => codicorto = value; }
    }
}
