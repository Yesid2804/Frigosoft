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
        public DateTime fecha{ get; set; }
        public string categoria{ get; set; }


        public List<Venta> ListaVenta = new List<Venta>();

        public Venta(int idVenta, DateTime fecha, double cantidad, double subtotal, double precio, double valortotal, string categoria)
        {
            this.idVenta = idVenta;
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.subTotal = subTotal;
            this.valorTotal = valorTotal;
            this.categoria = categoria;
            this.precio = precio;
        }

        public void Agregar(DateTime fecha, double cantidad, double subTotal, string categoria,double precio)
        {
            Venta venta = new Venta(idVenta, fecha, cantidad, subTotal, precio,valorTotal, categoria );

            ListaVenta.Add(venta);
        }

        public void CalcularTotal()
        {
            double total=0;
            foreach (var v in ListaVenta)
            {
                total = v.subTotal + total;
            }
        }
    }
}
