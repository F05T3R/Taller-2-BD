using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Taller_2_BD
{
    public partial class Modifica : Form
    {
        public Modifica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrdenCompra ordenCompra = new OrdenCompra();
            ordenCompra.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inserta inserta = new Inserta();
            inserta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cambio cambio = new Cambio();
            cambio.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CantidadVenta cantidadVenta = new CantidadVenta();
            cantidadVenta.Show();
        }

        private void Modifica_Load(object sender, EventArgs e)
        {

        }
    }
}
