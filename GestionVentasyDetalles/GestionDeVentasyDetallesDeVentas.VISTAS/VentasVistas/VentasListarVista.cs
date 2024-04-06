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

namespace GestionDeVentasyDetallesDeVentas.VISTAS.VentasVistas
{
    public partial class VentasListarVista : Form
    {
        public VentasListarVista()
        {
            InitializeComponent();
        }
        VentasBss bss = new VentasBss();
        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            VentasInsertarVista fr = new VentasInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarVentasBss();
            }
        }

        private void VentasListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarVentasBss();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            int idVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            VentasEditarVista fr = new VentasEditarVista(idVentaSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarVentasBss();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int idVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Estás seguro de eliminar esta venta?", "Eliminación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarVentaBss(idVentaSeleccionada);
                dataGridView1.DataSource = bss.ListarVentasBss();
            }
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            DetalleVentaInsertarVista.IdVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleVentaEditarVista.IdVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);


        }
    }
}
