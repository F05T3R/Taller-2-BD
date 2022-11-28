using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Util
{
    class MyClass
    {

        public static string FoundCategoriaCode(string nombreCategoria)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT id FROM Categoria WHERE nombre = '" + nombreCategoria + "'";
            return conex.selectQueryScalar(query);
        }

        public static string FoundProveedorCode(string nombreProveedor)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT rut FROM Proveedor WHERE nombre = '" + nombreProveedor + "'";
            return conex.selectQueryScalar(query);
        }

        public static string FoundProductoCode(string nombreProducto)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT id FROM Producto WHERE nombre = '" + nombreProducto + "'";
            return conex.selectQueryScalar(query);
        }

        public static string FoundClienteCode(string nombreCliente)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT rut FROM Cliente WHERE nombre = '" + nombreCliente + "'";
            return conex.selectQueryScalar(query);
        }

        public static string FoundVendedorCode(string nombreVendedor)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT numero FROM Vendedor WHERE nombre = '" + nombreVendedor + "'";
            return conex.selectQueryScalar(query);
        }

        public static void CategoriaList(ComboBox comboBox)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable categoriaTable = conex.selectQuery("SELECT * FROM Categoria");
            for (int i = 0; i < categoriaTable.Rows.Count; i++)
            {
                comboBox.Items.Add(categoriaTable.Rows[i]["nombre"]);
            }
            conex.close();
        }

        public static void ProveedorList(ComboBox comboBox)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable proveedorTable = conex.selectQuery("SELECT * FROM Proveedor");
            for (int i = 0; i < proveedorTable.Rows.Count; i++)
            {
                comboBox.Items.Add(proveedorTable.Rows[i]["nombre"]);
            }
            conex.close();
        }

        public static void ProductoList(ComboBox comboBox)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable productoTable = conex.selectQuery("SELECT * FROM Producto");
            for (int i = 0; i < productoTable.Rows.Count; i++)
            {
                comboBox.Items.Add(productoTable.Rows[i]["nombre"]);
            }
            conex.close();
        }

        public static void ClienteList(ComboBox comboBox)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable clienteTable = conex.selectQuery("SELECT * FROM Cliente");
            for (int i = 0; i < clienteTable.Rows.Count; i++)
            {
                comboBox.Items.Add(clienteTable.Rows[i]["nombre"]);
                
            }
            conex.close();
        }

        public static void VendedorList(ComboBox comboBox)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable vendedorTable = conex.selectQuery("SELECT * FROM Vendedor");
            for (int i = 0; i < vendedorTable.Rows.Count; i++)
            {
                comboBox.Items.Add(vendedorTable.Rows[i]["nombre"]);
            }
            conex.close();
        }
    }
}
