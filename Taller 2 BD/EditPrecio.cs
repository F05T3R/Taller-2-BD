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
    public partial class EditPrecio : Form
    {
        public EditPrecio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validar que todos los campos estén completados
            if (inputIDProducto.Text != "" && inputPrecio.Text != "")
            {
                //variables donde se almacena el int casteado
                int auxPrecio;
                //intentamos pasar los string a un int
                bool isParsable = Int32.TryParse(inputPrecio.Text, out auxPrecio);
                string productoCode = MyUtil.FoundProductoCode(inputIDProducto.Text); //Este metodo del script Util retorna el codigo de la categoria pasado por parametro
                if (isParsable)
                {
                    DialogResult result = MessageBox.Show("Está seguro que los datos son correctos?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); //result almacena el tipo de boton que apreto el usuario
                    if (result.Equals(DialogResult.Yes)) //selecciona el boton que esta seguro
                    {
                        try
                        {
                            ConexMySQL conex = new ConexMySQL();
                            conex.open();
                            string query = "UPDATE Producto SET precio = " + auxPrecio + " where id = '" + productoCode + "'";
                            int response = conex.executeNonQuery(query);

                            if (response != -1) MessageBox.Show("Se ha modificado el precio del producto");
                            else MessageBox.Show("Ha ocurrido un error, no se pudo modificar el precio", "ERROR");
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
                    MessageBox.Show("Debe ingresar un número en precio", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
        }

        private void EditPrecio_Load(object sender, EventArgs e)
        {
            MyUtil.ProductoList(inputIDProducto);
        }
    }
}
