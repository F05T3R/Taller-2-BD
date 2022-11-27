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
    public partial class AddVendedor : Form
    {
        public AddVendedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validar que todos los campos estén completados
            if (inputNombre.Text != "" && inputSalario.Text != "" && inputFecha.Text != "")
            {
                //variables donde se almacena el int casteado
                int auxSalario;
                //intentamos pasar los string a un int
                bool isParsable = Int32.TryParse(inputSalario.Text, out auxSalario);
                //Para convertir a formato YYYY-MM-DD
                string auxFecha = inputFecha.Value.ToString("yyyy-MM-dd");
                if (isParsable) //confirmamos que se ingresa un int al salario
                {
                    DialogResult result = MessageBox.Show("Está seguro que los datos son correctos?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); //result almacena el tipo de boton que apreto el usuario
                    if (result.Equals(DialogResult.Yes)) //selecciona el boton que esta seguro
                    {
                        try
                        {
                            ConexMySQL conex = new ConexMySQL();
                            conex.open();
                            string query = "INSERT INTO Vendedor (nombre, salario, fecha_contratacion) VALUES ('" + inputNombre.Text + "', '" + auxSalario + "', '" + auxFecha + "')";
                            int response = conex.executeNonQuery(query);

                            if (response != -1) MessageBox.Show("Se ha agregado el vendedor");
                            else MessageBox.Show("Ha ocurrido un error, no se pudo agregar el vendedor", "ERROR");
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
                    MessageBox.Show("Debe ingresar un número en salario", "ERROR");
                }

            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
        }

        private void AddVendedor_Load(object sender, EventArgs e)
        {

        }
    }
}
