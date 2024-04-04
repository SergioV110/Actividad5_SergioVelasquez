using GestionDeVentasyDetallesDeVentas.MODELOS;
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

namespace GestionDeVentasyDetallesDeVentas.VISTAS.ProductosVistas
{
    public partial class ProductosEditarVista : Form
    {
        int idx = 0;
        Productos productos = new Productos();
        ProductosBss bss = new ProductosBss();
        public ProductosEditarVista(int idProductoSeleccionado)
        {
            idx = idProductoSeleccionado;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productos.NombreProducto = textBox1.Text;
            productos.PrecioUnitario = Convert.ToDecimal(textBox2.Text);

            bss.EditarProductoBss(productos);
            MessageBox.Show("Datos Actualizados");
        }

        private void ProductosEditarVista_Load(object sender, EventArgs e)
        {
            productos = bss.ObtenerProductoIdBss(idx);
            textBox1.Text = productos.NombreProducto;
            textBox2.Text = productos.PrecioUnitario.ToString();
        }
    }
}
