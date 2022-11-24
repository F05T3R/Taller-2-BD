using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using MyUtil = Util.MyClass;

namespace Taller_2_BD
{
    public partial class AddProducto : Form
    {
        public AddProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validar que todos los campos estén completados
            if (inputNombre.Text != "" && inputPrecio.Text != "" && inputStock.Text != "" && inputCategoriaProducto.Text != "")
            {
                //variables donde se almacena el int casteado
                int auxPrecio;
                int auxStock;
                //intentamos pasar los string a un int
                bool isParsable = Int32.TryParse(inputPrecio.Text, out auxPrecio);
                bool isParsable2 = Int32.TryParse(inputStock.Text, out auxStock);
                string categoriaCode = MyUtil.FoundCategoriaCode(inputCategoriaProducto.Text); //Este metodo del script Util retorna el codigo de la categoria pasado por parametro
                //Debug.Print(categoriaCode);
                if (isParsable && isParsable2) //confirmamos que se ingresa un int en precio y stock
                {
                    DialogResult result = MessageBox.Show("Está seguro que los datos son correctos?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); //result almacena el tipo de boton que apreto el usuario
                    if (result.Equals(DialogResult.Yes)) //selecciona el boton que esta seguro
                    {
                        try
                        {
                            ConexMySQL conex = new ConexMySQL();
                            conex.open();
                            string query = "INSERT INTO Producto (nombre, precio, stock, Categoriaid) VALUES ('" + inputNombre.Text + "', '" + auxPrecio + "', '" + auxStock + "', '" + categoriaCode + "')";
                            int response = conex.executeNonQuery(query);

                            if (response != -1) MessageBox.Show("Se ha agregado el producto");
                            else MessageBox.Show("Ha ocurrido un error, no se pudo agregar el producto", "ERROR");
                            conex.close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Hubo un problema con la conexión.", "ERROR");
                        }
                    } 
                }
                else
                {
                    MessageBox.Show("Debe ingresar un número en precio y stock", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
        }

        private void AddProducto_Load(object sender, EventArgs e)
        {
            MyUtil.CategoriaList(inputCategoriaProducto);
        }
    }
}
