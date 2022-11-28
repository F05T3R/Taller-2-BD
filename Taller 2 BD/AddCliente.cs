using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Taller_2_BD
{
    public partial class AddCliente : Form
    {
        public AddCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validar que todos los campos estén completados
            if (inputRUT.Text != "" && inputNombre.Text != "" && inputSaldo.Text != "" && inputDireccion.Text != "" && inputTelefono.Text != "")
            {
                //variables donde se almacena el int casteado
                int auxSaldo;
                int auxTelefono;
                //intentamos pasar los string a un int
                bool isParsable = Int32.TryParse(inputSaldo.Text, out auxSaldo);
                bool isParsable2 = Int32.TryParse(inputTelefono.Text, out auxTelefono);
                if (isParsable && isParsable2) //confirmamos que se ingresa un int en saldo y telefono
                {
                    DialogResult result = MessageBox.Show("Está seguro que los datos son correctos?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); //result almacena el tipo de boton que apreto el usuario
                    if (result.Equals(DialogResult.Yes)) //selecciona el boton que esta seguro
                    {
                        try
                        {
                            ConexMySQL conex = new ConexMySQL();
                            conex.open();
                            bool estadoCliente = true;
                            string query = "INSERT INTO Cliente (rut, nombre, saldo, direccion, telefono, estado) VALUES ('" + inputRUT.Text + "', '" + inputNombre.Text + "', '" + auxSaldo + "', '" + inputDireccion.Text + "', '" + auxTelefono + "', " + estadoCliente + ")";
                            int response = conex.executeNonQuery(query);

                            if (response != -1) MessageBox.Show("Se ha agregado al cliente");
                            else MessageBox.Show("Ha ocurrido un error, no se pudo agregar al cliente", "ERROR");
                            conex.close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Hubo un problema con la conexión", "ERROR");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un número en saldo y telefono", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
        }

        private void AddCliente_Load(object sender, EventArgs e)
        {
           
        }
    }
}
