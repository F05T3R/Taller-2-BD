using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Taller_2_BD
{
    public partial class Inserta : Form
    {
        public Inserta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCliente addCliente = new AddCliente();
            addCliente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddProveedor addProveedor = new AddProveedor();
            addProveedor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddProducto addProducto = new AddProducto();
            addProducto.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddVendedor addVendedor = new AddVendedor();
            addVendedor.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddCategoria addCategoria = new AddCategoria();
            addCategoria.Show();
        }

        private void Inserta_Load(object sender, EventArgs e)
        {

        }
    }
}
