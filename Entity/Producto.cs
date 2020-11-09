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


        
        public Producto(string nombre, string categoria, double precio)
        {
            this.nombre = nombre;
            this.categoria= categoria;
            this.precio = precio;
        }
    }
}
