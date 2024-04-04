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

namespace GestionDeVentasyDetallesDeVentas.VISTAS.VentasVistas
{
    public partial class VentasEditarVista : Form
    {
        int idx = 0;
        Ventas ventas = new Ventas();
        VentasBss bss = new VentasBss();
        public VentasEditarVista(int idVentaSeleccionada)
        {
            idx = idVentaSeleccionada;
            InitializeComponent();
        }

        private void VentasEditarVista_Load(object sender, EventArgs e)
        {
            ventas = bss.ObtenerVentaIdBss(idx);
            dateTimePicker1.Value = ventas.FechaVenta;
            textBox1.Text = ventas.TotalVenta.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventas.FechaVenta = dateTimePicker1.Value;
            ventas.TotalVenta = Convert.ToDecimal(textBox1.Text);

            bss.EditarVentaBss(ventas);
            MessageBox.Show("La Venta han sido Actualizados");
        }
    }
}
