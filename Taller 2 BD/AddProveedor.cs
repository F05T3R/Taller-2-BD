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
    public partial class AddProveedor : Form
    {
        public AddProveedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validar que todos los campos estén completados
            if (inputRUT.Text != "" && inputNombre.Text != "" && inputDireccion.Text != "")
            {
                DialogResult result = MessageBox.Show("Está seguro que los datos son correctos?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); //result almacena el tipo de boton que apreto el usuario
                if (result.Equals(DialogResult.Yes)) //selecciona el boton que esta seguro
                {
                    try
                    {
                        ConexMySQL conex = new ConexMySQL();
                        conex.open();
                        string query = "INSERT INTO Proveedor (rut, nombre, direccion) VALUES ('" + inputRUT.Text + "', '" + inputNombre.Text + "', '" + inputDireccion.Text + "')";
                        int response = conex.executeNonQuery(query);

                        if (response != -1) MessageBox.Show("Se ha agregado el proveedor");
                        else MessageBox.Show("Ha ocurrido un error, no se pudo agregar el proveedor", "ERROR");
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
                MessageBox.Show("Debe completar todos los campos");
            }
        }

        private void AddProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
