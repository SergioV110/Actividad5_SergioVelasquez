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
    public partial class VentasInsertarVista : Form
    {
        public VentasInsertarVista()
        {
            InitializeComponent();
        }
        VentasBss bss = new VentasBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.FechaVenta = dateTimePicker1.Value;
            ventas.TotalVenta = Convert.ToDecimal(textBox1.Text);

            bss.InsertarVentaBss(ventas);
            MessageBox.Show("Se ha registrado la venta correctamente");
        }
    }
}
