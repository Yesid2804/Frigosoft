using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Producto
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string categoria { get; set; }
        public double precio { get; set; }

        List<Producto> ListaProductos = new List<Producto>();

        public Producto(string nombre, string categoria, double precio)
        {
            this.nombre = nombre;
            this.categoria= categoria;
            this.precio = precio;
        }


        public void Agregar(string nombre, string categoria, double precio)
        {
            Producto producto = new Producto(nombre, categoria, precio);

            ListaProductos.Add(producto);
        }
    }
}
