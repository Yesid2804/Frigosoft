using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string contacto{ get; set; }

        public Proveedor(string nombre, string contacto)
        {
            this.nombre = nombre;
            this.contacto=contacto;
        }
    }
}
