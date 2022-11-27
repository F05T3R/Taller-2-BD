using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Taller_2_BD
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listados listados = new Listados();
            listados.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListaCantidad listaCantidad = new ListaCantidad();
            listaCantidad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListadosEspecificos listadosEspecificos = new ListadosEspecificos();
            listadosEspecificos.Show();
        }
    }
}
