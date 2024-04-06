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
    public partial class DetalleVentaEditarVista : Form
    {
        int idx = 0;
        DetalleVenta detalleVenta = new DetalleVenta();
        DetalleVentaBss bss = new DetalleVentaBss();
        VentasBss bssventas = new VentasBss();
        ProductosBss bssproductos = new ProductosBss();
        public DetalleVentaEditarVista(int idDetalleVentaSeleccionado)
        {
            idx = idDetalleVentaSeleccionado;
            InitializeComponent();
        }

        public static int IdProductoSeleccionado = 0;
        public static int IdVentaSeleccionada = 0;

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            detalleVenta.IdVenta = IdVentaSeleccionada;
            detalleVenta.IdProducto = IdProductoSeleccionado;
            detalleVenta.Cantidad = Convert.ToInt32(textBox3.Text);
            detalleVenta.PrecioUnitario = Convert.ToDecimal(textBox4.Text);
            detalleVenta.TotalDetalle = Convert.ToDecimal(textBox5.Text);

            bss.EditarDetalleVentaBss(detalleVenta);
            MessageBox.Show("Datos Actualizados");
        }

        private void DetalleVentaEditarVista_Load(object sender, EventArgs e)
        {
            detalleVenta = bss.ObtenerDetalleVentaIdBss(idx);
            textBox1.Text = Convert.ToString(detalleVenta.IdVenta);
            textBox2.Text = Convert.ToString(detalleVenta.IdProducto);
            textBox3.Text = Convert.ToString(detalleVenta.Cantidad);
            textBox4.Text = Convert.ToString(detalleVenta.PrecioUnitario);
            textBox5.Text = Convert.ToString(detalleVenta.TotalDetalle);
        }

        public void buttonSeleccionarIdVenta_Click(object sender, EventArgs e)
        {
            VentasListarVista fr = new VentasListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Ventas ventas = bssventas.ObtenerVentaIdBss(IdVentaSeleccionada);
                textBox1.Text = Convert.ToString(ventas.IdVenta);
            }
        }

        public void buttonSeleccionarIdProducto_Click(object sender, EventArgs e)
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
