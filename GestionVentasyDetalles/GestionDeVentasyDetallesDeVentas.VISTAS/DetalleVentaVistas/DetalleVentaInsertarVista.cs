using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDeVentasyDetallesDeVentas.BSS;
using GestionDeVentasyDetallesDeVentas.MODELOS;
using GestionDeVentasyDetallesDeVentas.VISTAS.ProductosVistas;
using GestionDeVentasyDetallesDeVentas.VISTAS.VentasVistas;

namespace GestionDeVentasyDetallesDeVentas.VISTAS.DetalleVentaVistas
{
    public partial class DetalleVentaInsertarVista : Form
    {
        DetalleVentaBss bss = new DetalleVentaBss();
        VentasBss bssventas = new VentasBss();
        ProductosBss bssproductos = new ProductosBss();
        public DetalleVentaInsertarVista()
        {
            InitializeComponent();
        }

        public static int IdVentaSeleccionada { get; internal set; }
        public static int IdProductoSeleccionado { get; internal set; }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            DetalleVenta detalleVenta = new DetalleVenta();
            detalleVenta.IdVenta = IdVentaSeleccionada;
            detalleVenta.IdProducto = IdProductoSeleccionado;
            detalleVenta.Cantidad = Convert.ToInt32(textBox3.Text);
            detalleVenta.PrecioUnitario = Convert.ToDecimal(textBox4.Text);
            detalleVenta.TotalDetalle = Convert.ToDecimal(textBox5.Text);

            bss.InsertarDetalleVentaBss(detalleVenta);
            MessageBox.Show("Se guardo correctamente el Detalle Venta");
        }

        private void buttonSeleccionarIdVenta_Click(object sender, EventArgs e)
        {
            VentasListarVista fr = new VentasListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Ventas venta = bssventas.ObtenerVentaIdBss(IdVentaSeleccionada);
                textBox1.Text = Convert.ToString(venta.IdVenta);
            }
        }

        private void buttonSeleccionarIdProducto_Click(object sender, EventArgs e)
        {
            ProductosListarVista fr = new ProductosListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Productos productos = bssproductos.ObtenerProductoIdBss(IdProductoSeleccionado);
                textBox2.Text = productos.NombreProducto;
            }
        }
    }
}
