using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Entity
{
    class Venta
    {
        public int id { get; set; }
        public int idVenta { get; set; }

        public double cantidad { get; set; }
        public double valorTotal{ get; set; }
        public double subTotal{ get; set; }
        public double precio{ get; set; }
        public string observacion{ get; set; }
        public DateTime fecha{ get; set; }
        public string categoria{ get; set; }


        public List<Venta> ListaVenta = new List<Venta>(); 

        public Venta(int idVenta,string observacion, DateTime fecha,double cantidad,double subTotal, double precio,double valorTotal,string categoria)
        {
            this.idVenta =idVenta;
            this.observacion = observacion;
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.subTotal = subTotal;
            this.valorTotal = valorTotal;
            this.categoria = categoria;
            this.precio = precio;
        }

        public void Agregar(DateTime fecha, double cantidad, double subTotal, string categoria,double precio)
        {

        }



    }
}
