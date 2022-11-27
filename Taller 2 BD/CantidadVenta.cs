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
    public partial class CantidadVenta : Form
    {
        public CantidadVenta()
        {
            InitializeComponent();
        }

        private void CantidadVenta_Load(object sender, EventArgs e)
        {
            MyUtil.ProveedorList(inputRUTProveedor);
            MyUtil.ProductoList(inputIDProducto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validar que todos los campos estén completados
            if (inputRUTProveedor.Text != "" && inputIDProducto.Text != "" && inputPrecioUnitario.Text != "" && inputCantSuministrada.Text != "")
            {
                //variables donde se almacena el int casteado
                int auxPrecioUnitario;
                int auxCantSuministrada;
                //intentamos pasar los string a un int
                bool isParsable = Int32.TryParse(inputPrecioUnitario.Text, out auxPrecioUnitario);
                bool isParsable2 = Int32.TryParse(inputCantSuministrada.Text, out auxCantSuministrada);
                string proveedorCode = MyUtil.FoundProveedorCode(inputRUTProveedor.Text);
                string productoCode = MyUtil.FoundProductoCode(inputIDProducto.Text);
                if (isParsable && isParsable2)
                {
                    DialogResult result = MessageBox.Show("Está seguro que los datos son correctos?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); //result almacena el tipo de boton que apreto el usuario
                    if (result.Equals(DialogResult.Yes)) //selecciona el boton que esta seguro
                    {
                        try
                        {
                            ConexMySQL conex = new ConexMySQL();
                            conex.open();
                            string query = "INSERT INTO Proveedor_Producto (Proveedorrut, Productoid, precio_unitario, cantidad_suministrada) VALUES ('" + proveedorCode + "', '" + productoCode + "', '" + auxPrecioUnitario + "', '" + auxCantSuministrada + "')";
                            int response = conex.executeNonQuery(query);

                            if (response != -1)
                            {
                                string queryUpdate = "UPDATE Producto SET stock = stock + '" + auxCantSuministrada + "' WHERE id = '" + productoCode + "'";
                                int response2 = conex.executeNonQuery(queryUpdate);
                                MessageBox.Show("Se ha agregado la venta");
                                if (response2 != -1) MessageBox.Show("Se ha actualizado el stock del producto");
                                else MessageBox.Show("Ha ocurrido un error, no se pudo actualizar el stock del producto", "ERROR");
                            }
                            else 
                            {
                                MessageBox.Show("Ha ocurrido un error, no se pudo agregar la venta", "ERROR");
                            } 
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
                    MessageBox.Show("Debe ingresar un número en precio y cantidad", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
        }
    }
}
