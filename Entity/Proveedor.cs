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

        public Boolean cerdo { get; set; }
        public Boolean pollo { get; set; }
        public Boolean res { get; set; }
        public Boolean embutido { get; set; }



        List<Proveedor> ListaProveedores = new List<Proveedor>();
        public Proveedor(string nombre, string contacto,Boolean cerdo, Boolean pollo, Boolean res, Boolean embutido)
        {
            this.nombre = nombre;
            this.contacto=contacto;
            this.pollo = pollo;
            this.cerdo= cerdo;
            this.res = res;
            this.embutido= embutido;

        }

        public void Agregar(string nombre, string contacto, Boolean cerdo, Boolean pollo, Boolean res, Boolean embutido)
        {
            Proveedor proveedor = new Proveedor( nombre, contacto, cerdo, pollo, res,embutido);

            ListaProveedores.Add(proveedor);
        }


    }
}
