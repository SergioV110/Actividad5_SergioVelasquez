using GestionDeVentasyDetallesDeVentas.BSS;
using GestionDeVentasyDetallesDeVentas.VISTAS.DetalleVentaVistas;
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
    public partial class ProductosListarVista : Form
    {
        public ProductosListarVista()
        {
            InitializeComponent();
        }
        ProductosBss bss = new ProductosBss();
        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            DetalleVentaInsertarVista.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleVentaEditarVista.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            ProductosInsertarVista fr = new ProductosInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarProductosBss();
            }
        }

        private void ProductosListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProductosBss();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            int idProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProductosEditarVista fr = new ProductosEditarVista(idProductoSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarProductosBss();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int idProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este producto?", "Eliminación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarProductoBss(idProductoSeleccionado);
                dataGridView1.DataSource = bss.ListarProductosBss();
            }
        }
    }
}
