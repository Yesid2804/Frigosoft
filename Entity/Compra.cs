using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    class Compra
    {
        public int Id { get; set; }
        public int  idProducto{ get; set; }
        public double cantidad { get; set; }
        public double totalCompra{ get; set; }



        public Compra(int idProducto, double cantidad, double totalCompra)
        {
            this.idProducto = idProducto;
            this.cantidad= cantidad;
            this.totalCompra = totalCompra;
        }


    }
}
