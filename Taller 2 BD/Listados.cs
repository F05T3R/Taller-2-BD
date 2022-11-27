using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1;
using MyUtil = Util.MyClass;

namespace Taller_2_BD
{
    public partial class Listados : Form
    {
        public Listados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ListProveedor();
            }
            else if (radioButton2.Checked)
            {
                ListCliente();
            }
            else if (radioButton3.Checked)
            {
                ListProducto();
            }
            else if (radioButton4.Checked)
            {
                ListCategoria();
            }
            else if (radioButton5.Checked)
            {
                ListVendedor();
            }
        }

        private void Listados_Load(object sender, EventArgs e)
        {
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton5);
            radioButton1.Text = "Listado de proveedores";
            radioButton2.Text = "Listado de clientes";
            radioButton3.Text = "Listado de productos";
            radioButton4.Text = "Listado de categorías";
            radioButton5.Text = "Listado de vendedores";
        }

        public void ListProveedor()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT * FROM Proveedor";
            dataGridView1.DataSource = conex.selectQuery(query);
        }

        public void ListCliente()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT * FROM Cliente";
            dataGridView1.DataSource = conex.selectQuery(query);
        }

        public void ListProducto()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT * FROM Producto";
            dataGridView1.DataSource = conex.selectQuery(query);
        }

        public void ListCategoria()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT * FROM Categoria";
            dataGridView1.DataSource = conex.selectQuery(query);
        }

        public void ListVendedor()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT * FROM Vendedor";
            dataGridView1.DataSource = conex.selectQuery(query);
        }
    }
}
