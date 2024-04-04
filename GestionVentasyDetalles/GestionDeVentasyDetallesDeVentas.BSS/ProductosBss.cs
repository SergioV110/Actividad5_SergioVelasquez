using GestionDeVentasyDetallesDeVentas.DAL;
using GestionDeVentasyDetallesDeVentas.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeVentasyDetallesDeVentas.BSS
{
    public class ProductosBss
    {
        ProductosDal dal = new ProductosDal();
        public DataTable ListarProductosBss()
        {
            return dal.ListarProductosDal();
        }

        public void InsertarProductoBss(Productos productos)
        {
            dal.InsertarProductoDal(productos);
        }

        public Productos ObtenerProductoIdBss(int id)
        {
            return dal.ObtenerProductoIdDal(id);
        }

        public void EditarProductoBss(Productos productos)
        {
            dal.EditarProductoDal(productos);
        }

        public void EliminarProductoBss(int id)
        {
            dal.EliminarProductoDal(id);
        }
    }
}
