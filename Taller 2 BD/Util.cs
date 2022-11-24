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
            conex.close();
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
    }
}
