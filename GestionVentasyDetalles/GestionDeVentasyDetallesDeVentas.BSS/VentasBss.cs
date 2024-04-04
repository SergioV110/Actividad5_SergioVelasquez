using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeVentasyDetallesDeVentas.DAL;
using GestionDeVentasyDetallesDeVentas.MODELOS;

namespace GestionDeVentasyDetallesDeVentas.BSS
{
    public class VentasBss
    {
        VentasDal dal = new VentasDal();
        public DataTable ListarVentasBss()
        {
            return dal.ListarVentasDal();
        }

        public void InsertarVentaBss(Ventas ventas)
        {
            dal.InsertarVentaDal(ventas);
        }

        public Ventas ObtenerVentaIdBss(int id)
        {
            return dal.ObtenerVentaIdDal(id);
        }

        public void EditarVentaBss(Ventas ventas)
        {
            dal.EditarVentaDal(ventas);
        }

        public void EliminarVentaBss(int id)
        {
            dal.EliminarVentaDal(id);
        }
    }
}
