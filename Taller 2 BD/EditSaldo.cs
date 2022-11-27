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
    public partial class EditSaldo : Form
    {
        public EditSaldo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validar que todos los campos estén completados
            if (inputRUT.Text != "" && inputSaldo.Text != "")
            {
                //variables donde se almacena el int casteado
                int auxSaldo;
                //intentamos pasar los string a un int
                bool isParsable = Int32.TryParse(inputSaldo.Text, out auxSaldo);
                string clienteCode = MyUtil.FoundClienteCode(inputRUT.Text); //Este metodo del script Util retorna el codigo de la categoria pasado por parametro
                if (isParsable)
                {
                    DialogResult result = MessageBox.Show("Está seguro que los datos son correctos?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); //result almacena el tipo de boton que apreto el usuario
                    if (result.Equals(DialogResult.Yes)) //selecciona el boton que esta seguro
                    {
                        try
                        {
                            ConexMySQL conex = new ConexMySQL();
                            conex.open();
                            string query = "UPDATE Cliente SET saldo = saldo + " + auxSaldo + " where rut = '" + clienteCode + "'";
                            int response = conex.executeNonQuery(query);

                            if (response != -1) MessageBox.Show("Se ha modificado el saldo del cliente");
                            else MessageBox.Show("Ha ocurrido un error, no se pudo modificar el saldo", "ERROR");
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
                    MessageBox.Show("Debe ingresar un número en saldo", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
        }

        private void EditSaldo_Load(object sender, EventArgs e)
        {
            MyUtil.ClienteList(inputRUT);
        }
    }
}
