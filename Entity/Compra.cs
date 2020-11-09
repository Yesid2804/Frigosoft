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
        public double subTotal{ get; set; }

        public double totalCompra{ get; set; }
        List<Compra> ListaCompras= new List<Compra>();



        public Compra(int idProducto, double cantidad, double subTotal, double totalCompra)
        {
            this.idProducto = idProducto;
            this.cantidad= cantidad;
            this.subTotal = subTotal;
            this.totalCompra = totalCompra;
        }

        public void Agregar(int idProducto, double cantidad, double subTotal)
        {
            Compra compra= new Compra(idProducto, cantidad, subTotal,totalCompra);

            ListaCompras.Add(compra);
        }
    }
}
