using GestionDeVentasyDetallesDeVentas.BSS;
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

namespace GestionDeVentasyDetallesDeVentas.VISTAS.ProductosVistas
{
    public partial class ProductosInsertarVista : Form
    {
        public ProductosInsertarVista()
        {
            InitializeComponent();
        }
        ProductosBss bss = new ProductosBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.NombreProducto = textBox1.Text;
            productos.PrecioUnitario = Convert.ToDecimal(textBox2.Text);

            bss.InsertarProductoBss(productos);
            MessageBox.Show("El producto ha sido ingresado correctamente");
        }
    }
}
