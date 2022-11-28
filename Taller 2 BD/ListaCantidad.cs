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
    public partial class ListaCantidad : Form
    {
        public ListaCantidad()
        {
            InitializeComponent();
            this.comboBox1.Hide();
        }

        private bool validarComboBox()
        {
             if (comboBox1.Text == "")
            {
                MessageBox.Show("Seleccione el campo", "ERROR");
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && validarComboBox())
            {
                CantProductoCategoria();
                
            }
            else if (radioButton2.Checked && validarComboBox())
            {
                CantCompraCliente();
            }
            else if (radioButton3.Checked && validarComboBox())
            {
                CantTotal();
            }
            else if (radioButton4.Checked)
            {
                Top5();
            }
            else if (radioButton5.Checked && validarComboBox())
            {
                CantProductoCliente();
            }
        }

        private void ListaCantidad_Load(object sender, EventArgs e)
        {
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton5);
            radioButton1.Text = "Productos asociados a una categoría";
            radioButton2.Text = "Órdenes de compra asociadas a un cliente, en los últimos 30 días";
            radioButton3.Text = "El total de productos que suministra un cierto proveedor";
            radioButton4.Text = "Los 5 productos más vendidos de la semana anterior y su cantidad";
            radioButton5.Text = "Los productos que ha comprado un cliente durante el año y su cantidad";
        }

        public void CantProductoCategoria()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string code = MyUtil.FoundCategoriaCode(comboBox1.Text);
            string query = "SELECT count(*) FROM Producto p INNER JOIN Categoria c ON p.Categoriaid = c.id WHERE c.id = '" + code + "'";
            dataGridView1.DataSource = conex.selectQuery(query);
        }

        public void CantCompraCliente()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string code = MyUtil.FoundClienteCode(comboBox1.Text);
            string query = "SELECT count(*) FROM Boleta WHERE(fecha BETWEEN(curdate() - interval 30 DAY) AND curdate()) AND Clienterut = '" + code + "'";
            dataGridView1.DataSource = conex.selectQuery(query);
        }

        public void CantTotal()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string code = MyUtil.FoundProveedorCode(comboBox1.Text);
            string query = "SELECT count(Productoid) FROM Proveedor_Producto WHERE Proveedorrut = '" + code + "'";
            dataGridView1.DataSource = conex.selectQuery(query);
        }

        public void Top5()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT p.id, p.nombre, sum(pb.cantidad) FROM(Producto_Boleta pb INNER JOIN Producto p ON pb.Productoid = p.id) INNER JOIN Boleta b ON pb.Boletaid = b.id WHERE(b.fecha BETWEEN(curdate() - interval 1 WEEK) AND curdate()) GROUP BY p.nombre ORDER BY pb.cantidad DESC LIMIT 5";
            dataGridView1.DataSource = conex.selectQuery(query);
        }

        public void CantProductoCliente()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string code = MyUtil.FoundClienteCode(comboBox1.Text);
            string query = "SELECT p.id, p.nombre, sum(pb.cantidad) FROM(Producto p INNER JOIN Producto_Boleta pb ON p.id = pb.Productoid) INNER JOIN Boleta b ON pb.Boletaid = b.id WHERE YEAR(b.fecha) = YEAR(CURDATE()) AND b.Clienterut = '" + code + "' GROUP BY p.nombre";
            dataGridView1.DataSource = conex.selectQuery(query);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = null;
            this.comboBox1.Items.Clear();
            this.comboBox1.Show();
            MyUtil.CategoriaList(comboBox1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = null;
            this.comboBox1.Items.Clear();
            this.comboBox1.Show();
            MyUtil.ClienteList(comboBox1);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = null;
            this.comboBox1.Items.Clear();
            this.comboBox1.Show();
            MyUtil.ProveedorList(comboBox1);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = null;
            this.comboBox1.Items.Clear();
            this.comboBox1.Hide();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = null;
            this.comboBox1.Items.Clear();
            this.comboBox1.Show();
            MyUtil.ClienteList(comboBox1);
        }

        
    }
}
