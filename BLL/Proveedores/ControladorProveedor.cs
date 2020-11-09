using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Proveedores
{
    public class ControladorProveedor
    {
        public Boolean addProveedor(Proveedor proveedor)
        {
            using (var context = new DataContext())
            {
                try
                {
                    // Creates the database if not exists
                    context.Database.EnsureCreated();
                    context.Proveedores.Add(proveedor);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                    throw;
                }
                
            }
        }
    }
}
