using GestionDeVentasyDetallesDeVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeVentasyDetallesDeVentas.VISTAS.DetalleVentaVistas
{
    public partial class DetalleVentaListarVista : Form
    {
        DetalleVentaBss bss = new DetalleVentaBss();
        public DetalleVentaListarVista()
        {
            InitializeComponent();
        }

        private void DetalleVentaListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarDetallesVentaBss();
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            DetalleVentaInsertarVista fr = new DetalleVentaInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarDetallesVentaBss();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            int idDetalleVentaSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleVentaEditarVista fr = new DetalleVentaEditarVista(idDetalleVentaSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarDetallesVentaBss();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int idDetalleVentaSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este detalle de venta?", "Eliminación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarDetalleVentaBss(idDetalleVentaSeleccionado);
                dataGridView1.DataSource = bss.ListarDetallesVentaBss();
            }
        }
    }
}
