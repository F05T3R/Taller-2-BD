using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1;
using MyUtil = Util.MyClass;

namespace Taller_2_BD
{
    public partial class EditEstado : Form
    {
        public EditEstado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validar que todos los campos estén completados
            if (inputRUT.Text != "")
            {
                string clienteCode = MyUtil.FoundClienteCode(inputRUT.Text);
                DialogResult result = MessageBox.Show("Está seguro que desea modificar estos datos?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); //result almacena el tipo de boton que apreto el usuario
                if (result.Equals(DialogResult.Yes)) //selecciona el boton que esta seguro
                {
                    try
                    {
                        ConexMySQL conex = new ConexMySQL();
                        conex.open();
                        bool clienteState = false;
                        string query = "UPDATE Cliente SET estado = " + clienteState + " WHERE rut = '" + clienteCode + "'";
                        int response = conex.executeNonQuery(query);
                        if (clienteState == false)
                        {
                            MessageBox.Show("Este cliente ya ha sido inhabilitado");
                        }
                        if (response != -1) MessageBox.Show("Se ha desactivado al cliente");
                        else MessageBox.Show("Ha ocurrido un error, no se pudo desactivar al cliente", "ERROR");
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

        private void EditEstado_Load(object sender, EventArgs e)
        {
            MyUtil.ClienteList(inputRUT);
        }
    }
}
