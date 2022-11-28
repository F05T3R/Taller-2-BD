using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using WindowsFormsApp1;
using MyUtil = Util.MyClass;

namespace Taller_2_BD
{
    public partial class ListadosEspecificos : Form
    {
        public ListadosEspecificos()
        {
            InitializeComponent();
            this.comboBox1.Hide();
            this.comboBox2.Hide();
            this.dateTimePicker1.Hide();
        }

        private bool validarInputs()
        {
            if (comboBox1.Text == "" && comboBox2.Text == "" && dateTimePicker1.Text == "")
            {
                MessageBox.Show("No deje ningún campo vacio", "ERROR");
                return false;
            }
            return true;
        }

        private void ListadosEspecificos_Load(object sender, EventArgs e)
        {
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.radioButton8);
            this.groupBox1.Controls.Add(this.radioButton9);
            this.groupBox1.Controls.Add(this.radioButton10);
            radioButton1.Text = "Datos de un vendedor, incluyendo la antigüedad (en años) del vendedor en la empresa";
            radioButton2.Text = "Los vendedores de mayor y menor antigüedad en la empresa";
            radioButton3.Text = "Datos de una orden de compra, incluyendo el cliente, el vendedor y los productos de la orden";
            radioButton4.Text = "La categoría de un producto";
            radioButton5.Text = "Los proveedores que suministran un producto";
            radioButton6.Text = "Los productos que suministra un proveedor con el precio y su cantidad";
            radioButton7.Text = "Seleccionado un rut de cliente, mostrar su rut, nombre, saldo en su cuenta, monto total por órdenes de compras emitidas en los últimos 3 meses";
            radioButton8.Text = "Los productos de una cierta categoría que ha comprado un cliente";
            radioButton9.Text = "Los productos que no han participado en órdenes de compra en el último mes";
            radioButton10.Text = "Los productos que fueron comprados por los clientes en un cierto día";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && validarInputs())
            {
                Especifico1();
            }
            else if (radioButton2.Checked)
            {
                Especifico2();
            }
            else if (radioButton3.Checked)
            {
                Especifico3();
            }
            else if (radioButton4.Checked && validarInputs())
            {
                Especifico4();
            }
            else if (radioButton5.Checked && validarInputs())
            {
                Especifico5();
            }
            else if (radioButton6.Checked && validarInputs())
            {
                Especifico6();
            }
            else if (radioButton7.Checked && validarInputs())
            {
                Especifico7();
            }
            else if (radioButton8.Checked && validarInputs())
            {
                Especifico8();
            }
            else if (radioButton9.Checked)
            {
                Especifico9();
            }
            else if (radioButton10.Checked && validarInputs())
            {
                Especifico10();
            }

        }

        public void Especifico1()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string code = MyUtil.FoundVendedorCode(comboBox1.Text);
            string query = "SELECT *, YEAR(curdate()) - YEAR(fecha_contratacion) FROM Vendedor WHERE numero = '" + code + "'";
            dataGridView1.DataSource = conex.selectQuery(query);
        }

        public void Especifico2()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT numero, nombre, YEAR(curdate()) - YEAR(fecha_contratacion) FROM Vendedor ORDER BY fecha_contratacion ASC";
            dataGridView1.DataSource = conex.selectQuery(query);
        }

        public void Especifico3()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT b.fecha, b.descuento, b.montoFinal, b.Clienterut, b.Vendedornumero, pb.Productoid FROM Boleta b INNER JOIN Producto_Boleta pb ON b.id = pb.Boletaid";
            dataGridView1.DataSource = conex.selectQuery(query);
        }

        public void Especifico4()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string code = MyUtil.FoundProductoCode(comboBox1.Text);
            string query = "SELECT c.nombre, c.descripcion FROM Categoria c INNER JOIN Producto p ON c.id = p.Categoriaid WHERE p.id = '" + code + "'";
            dataGridView1.DataSource = conex.selectQuery(query);
        }

        public void Especifico5()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string code = MyUtil.FoundProductoCode(comboBox1.Text);
            string query = "SELECT p.rut, p.nombre, p.direccion FROM(Proveedor p INNER JOIN Proveedor_Producto pp ON p.rut = pp.Proveedorrut) INNER JOIN Producto pr ON pp.Productoid = pr.id WHERE pr.id = '" + code + "'";
            dataGridView1.DataSource = conex.selectQuery(query);
        }

        public void Especifico6()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string code = MyUtil.FoundProveedorCode(comboBox1.Text);
            string query = "SELECT p.id, p.nombre, pp.precio_unitario, pp.cantidad_suministrada FROM(Producto p INNER JOIN Proveedor_Producto pp on p.id = pp.Productoid) INNER JOIN Proveedor pr ON pp.Proveedorrut = pr.rut WHERE pr.rut = '" + code + "'";
            dataGridView1.DataSource = conex.selectQuery(query);
        }

        public void Especifico7()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string code = MyUtil.FoundClienteCode(comboBox1.Text);
            string query = "SELECT b.Clienterut, c.nombre, c.saldo, sum(b.montoFinal) FROM Cliente c INNER JOIN Boleta b ON c.rut = b.Clienterut WHERE(b.fecha BETWEEN(curdate() - interval 3 MONTH) AND curdate()) AND c.rut = '" + code + "'";
            dataGridView1.DataSource = conex.selectQuery(query);
        }

        public void Especifico8()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string code = MyUtil.FoundCategoriaCode(comboBox1.Text);
            string code2 = MyUtil.FoundClienteCode(comboBox2.Text);
            string query = "SELECT p.id, p.nombre FROM Categoria c INNER JOIN Producto p ON c.id = p.Categoriaid INNER JOIN Producto_Boleta pb ON p.id = pb.Productoid INNER JOIN Boleta b ON pb.Boletaid = b.id INNER JOIN Cliente cl ON b.Clienterut = cl.rut WHERE c.id = " + code + " AND cl.rut = '" + code2 + "'";
            dataGridView1.DataSource = conex.selectQuery(query);
        }

        public void Especifico9()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT p.id, p.nombre FROM Producto p INNER JOIN Producto_Boleta pb ON p.id = pb.Productoid WHERE NOT EXISTS(SELECT * FROM Boleta b WHERE pb.Boletaid = b.id AND b.fecha BETWEEN(curdate() - interval 1 MONTH) AND curdate())";
            dataGridView1.DataSource = conex.selectQuery(query);
        }

        public void Especifico10()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string code = MyUtil.FoundClienteCode(comboBox1.Text);
            string fecha = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            string query = "SELECT p.id, p.nombre FROM Producto p INNER JOIN Producto_Boleta pb ON p.id = pb.Productoid INNER JOIN Boleta b ON pb.Boletaid = b.id INNER JOIN Cliente c ON b.Clienterut = c.rut WHERE c.rut = '" + code + "' AND b.fecha = '" + fecha + "'";
            dataGridView1.DataSource = conex.selectQuery(query);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = null;
            this.comboBox2.DataSource = null;
            this.comboBox1.Items.Clear();
            this.comboBox2.Items.Clear();
            this.comboBox1.Show();
            this.comboBox2.Hide();
            this.dateTimePicker1.Hide();
            MyUtil.VendedorList(comboBox1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = null;
            this.comboBox2.DataSource = null;
            this.comboBox1.Items.Clear();
            this.comboBox2.Items.Clear();
            this.comboBox1.Hide();
            this.comboBox2.Hide();
            this.dateTimePicker1.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = null;
            this.comboBox2.DataSource = null;
            this.comboBox1.Items.Clear();
            this.comboBox2.Items.Clear();
            this.comboBox1.Hide();
            this.comboBox2.Hide();
            this.dateTimePicker1.Hide();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = null;
            this.comboBox2.DataSource = null;
            this.comboBox1.Items.Clear();
            this.comboBox2.Items.Clear();
            this.comboBox1.Show();
            this.comboBox2.Hide();
            this.dateTimePicker1.Hide();
            MyUtil.ProductoList(comboBox1);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = null;
            this.comboBox2.DataSource = null;
            this.comboBox1.Items.Clear();
            this.comboBox2.Items.Clear();
            this.comboBox1.Show();
            this.comboBox2.Hide();
            this.dateTimePicker1.Hide();
            MyUtil.ProductoList(comboBox1);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = null;
            this.comboBox2.DataSource = null;
            this.comboBox1.Items.Clear();
            this.comboBox2.Items.Clear();
            this.comboBox1.Show();
            this.comboBox2.Hide();
            this.dateTimePicker1.Hide();
            MyUtil.ProveedorList(comboBox1);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = null;
            this.comboBox2.DataSource = null;
            this.comboBox1.Items.Clear();
            this.comboBox2.Items.Clear();
            this.comboBox1.Show();
            this.comboBox2.Hide();
            this.dateTimePicker1.Hide();
            MyUtil.ClienteList(comboBox1);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = null;
            this.comboBox2.DataSource = null;
            this.comboBox1.Items.Clear();
            this.comboBox2.Items.Clear();
            this.comboBox1.Show();
            this.comboBox2.Show();
            this.dateTimePicker1.Hide();
            MyUtil.CategoriaList(comboBox1);
            MyUtil.ClienteList(comboBox2);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = null;
            this.comboBox2.DataSource = null;
            this.comboBox1.Items.Clear();
            this.comboBox2.Items.Clear();
            this.comboBox1.Hide();
            this.comboBox2.Hide();
            this.dateTimePicker1.Hide();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = null;
            this.comboBox2.DataSource = null;
            this.dataGridView1.DataSource = null;
            this.comboBox1.Items.Clear();
            this.comboBox2.Items.Clear();
            this.comboBox1.Show();
            this.comboBox2.Hide();
            this.dateTimePicker1.Show();
            MyUtil.ClienteList(comboBox1);
        }
    }
}
