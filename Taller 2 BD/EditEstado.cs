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
    public partial class EditEstado : Form
    {
        public EditEstado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validar que todos los campos estén completados
            if (inputRUT.Text != "" && inputEstado.Text != "")
            {

                string clienteCode = MyUtil.FoundClienteCode(inputRUT.Text);
                string clienteState = MyUtil.FoundClienteEstado(inputEstado.Text);
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                string querySelect = "SELECT estado FROM Cliente WHERE rut = '" + clienteCode + "'";
                string selectEstado = conex.selectQueryScalar(querySelect); //almacena la query
                if (clienteState != selectEstado) //la nueva modificación es distinta a lo encontró
                {
                    DialogResult result = MessageBox.Show("Está seguro que desea modificar estos datos?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); //result almacena el tipo de boton que apreto el usuario
                    if (result.Equals(DialogResult.Yes)) //selecciona el boton que esta seguro
                    {
                        string query = "UPDATE Cliente SET estado = '" + clienteState + "' where rut = '" + input + "'";
                    }
                }

            }
        }

        private void EditEstado_Load(object sender, EventArgs e)
        {
            MyUtil.ClienteList(inputRUT);
        }
    }
}
