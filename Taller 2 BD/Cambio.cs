using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Taller_2_BD
{
    public partial class Cambio : Form
    {
        public Cambio()
        {
            InitializeComponent();
        }

        private void Cambio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditPrecio editPrecio = new EditPrecio();
            editPrecio.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditSalario editSalario = new EditSalario();
            editSalario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditSaldo editSaldo = new EditSaldo();
            editSaldo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditEstado editEstado = new EditEstado();
            editEstado.Show();
        }
    }
}
