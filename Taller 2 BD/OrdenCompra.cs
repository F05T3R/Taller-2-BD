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
    public partial class OrdenCompra : Form
    {
        public OrdenCompra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validar que todos los campos estén completados
            if (inputFechaCompra.Text != "" && inputDescuento.Text != "" && inputMontoFinal.Text != "" && inputRUTCliente.Text != "" && inputRUTVendedor.Text != "")
            {
                //variables donde se almacena el int casteado
                int auxDescuento;
                //intentamos pasar los string a un int
                bool isParsable = Int32.TryParse(inputDescuento.Text, out auxDescuento);
                string auxFecha = inputFechaCompra.Value.ToString("yyyy-MM-dd");
                string clienteCode = MyUtil.FoundClienteCode(inputRUTCliente.Text);
                string vendedorCode = MyUtil.FoundVendedorCode(inputRUTVendedor.Text);
                int auxMontoFinal;
                if (isParsable)
                {

                }
            }
        }

        private void OrdenCompra_Load(object sender, EventArgs e)
        {
            MyUtil.ClienteList(inputRUTCliente);
            MyUtil.VendedorList(inputRUTVendedor);
        }
    }
}
