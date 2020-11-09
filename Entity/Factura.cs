using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    class Factura
    {
        public int id { get; set; }
        public int idVenta{ get; set; }
        public string observacion{ get; set; }
        public double valorTotal { get; set; }
        public DateTime fecha{ get; set; }




        public Factura(int idVenta, string observacion, double valorTotal, DateTime fecha)
        {
            this.idVenta = idVenta;
            this.observacion= observacion;
            this.valorTotal= valorTotal;
            this.fecha= fecha;
        }
    }
}
