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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputPassword.Text != "")
            {
              try
              {
                  string query = "SELECT password FROM PASSWORD";
                  ConexMySQL conex = new ConexMySQL();
                  conex.open();
                  string password = conex.selectQueryScalar(query);
                  conex.close();
                  string passwordInput = inputPassword.Text;
                  if (password == passwordInput)
                  {
                      Modifica modifica = new Modifica();
                      modifica.Show();
                      this.Close();
                  }
                  else
                  {
                      MessageBox.Show("Contraseña incorrecta, inténtelo de nuevo", "ERROR");
                  } 
              }
                  catch (Exception)
                  {
                      MessageBox.Show("Hubo un problema con la conexión.", "ERROR");
                  }  
            }
            else
            {
                MessageBox.Show("Debe completar el campo");
            }
        }

        private void Password_Load(object sender, EventArgs e)
        {

        }
    }
}
