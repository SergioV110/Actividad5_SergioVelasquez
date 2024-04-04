using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeVentasyDetallesDeVentas.MODELOS;

namespace GestionDeVentasyDetallesDeVentas.DAL
{
    public class VentasDal
    {
        Ventas ventas = new Ventas();
       public DataTable ListarVentasDal()
       {
            string consulta = "select * from ventas";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "table");
            return lista;
       }
        public void InsertarVentaDal(Ventas ventas)
        {
            string consulta = "insert into ventas values('" + ventas.FechaVenta + "'," +
                                                         "'" + ventas.TotalVenta + "')";
            conexion.Ejecutar(consulta);
        }

        public Ventas ObtenerVentaIdDal(int id)
        {
            string consulta = "select * from ventas where idventa = " + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "tabla");
            if (tabla.Rows.Count > 0)
            {
                ventas.IdVenta = Convert.ToInt32(tabla.Rows[0]["IdVenta"]);
                ventas.FechaVenta = Convert.ToDateTime(tabla.Rows[0]["FechaVenta"]);
                ventas.TotalVenta = Convert.ToDecimal(tabla.Rows[0]["TotalVenta"]);
            }
            return ventas;
        }

        public void EditarVentaDal(Ventas ventas)
        {
            string consulta = "update ventas set fechaventa='" + ventas.FechaVenta + "'," +
                                                        "totalventa='" + ventas.TotalVenta + "'" +
                                                "where idventa=" + ventas.IdVenta;
            conexion.Ejecutar(consulta);
        }

        public void EliminarVentaDal(int id)
        {
            string consulta = "delete from  ventas where IdVenta = " + id;
            conexion.Ejecutar(consulta);
        }

    }
}
