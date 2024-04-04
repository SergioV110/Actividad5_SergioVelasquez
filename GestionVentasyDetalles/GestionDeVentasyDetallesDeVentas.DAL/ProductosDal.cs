using GestionDeVentasyDetallesDeVentas.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestionDeVentasyDetallesDeVentas.DAL
{
    public class ProductosDal
    {
        Productos productos = new Productos();
        public DataTable ListarProductosDal()
        {
            string consulta = "select * from productos";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarProductoDal(Productos productos)
        {
            string consulta = "insert into productos values('" + productos.NombreProducto + "'," +
                                                         "'" + productos.PrecioUnitario + "')";
            conexion.Ejecutar(consulta);
        }

        public Productos ObtenerProductoIdDal(int id)
        {
            string consulta = "select * from productos where idproducto = " + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "tabla");
            if (tabla.Rows.Count > 0)
            {
                productos.IdProducto = Convert.ToInt32(tabla.Rows[0]["IdProducto"]);
                productos.NombreProducto = tabla.Rows[0]["NombreProducto"].ToString();
                productos.PrecioUnitario = Convert.ToDecimal(tabla.Rows[0]["PrecioUnitario"]);
            }
            return productos;
        }

        public void EditarProductoDal(Productos productos)
        {
            string consulta = "update productos set nombreproducto = '" + productos.NombreProducto + "'," +
                                                        "preciounitario='" + productos.PrecioUnitario + "'" +
                                                "where idproducto=" + productos.IdProducto;
            conexion.Ejecutar(consulta);
        }

        public void EliminarProductoDal(int id)
        {
            string consulta = "delete from productos where idproducto = " + id;
            conexion.Ejecutar(consulta);
        }
    }
}
