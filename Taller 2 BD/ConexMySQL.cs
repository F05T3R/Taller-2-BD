using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1{

    class ConexMySQL
    {

        private MySqlConnection conexion;

        public ConexMySQL()
        {

            var fileStream = new FileStream("config_file.txt", FileMode.Open, FileAccess.Read);

            using (var streamReader = new StreamReader(fileStream, System.Text.Encoding.UTF8))
            {

                string line = streamReader.ReadLine();

                this.conexion = new MySqlConnection(line);

            }

        }

        public void open()
        {

            this.conexion.Open();

        }

        public void close()
        {
            this.conexion.Close();
        }

        public string selectQueryScalar(string query, params string[] values)
        {

            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.Connection = this.conexion;
                cmd.CommandText = query;

                for (int pos = 0; pos < values.Length; pos += 2)
                {

                    cmd.Parameters.AddWithValue(values[pos], values[pos + 1]);

                }

                /**
                 * No se necesita cerrar ni cláusula using,
                 * por que una vez que rescata valor, se cierra automáticamente
                 */
                return cmd.ExecuteScalar().ToString();

            }

        }

        public DataTable selectQuery(string query, params string[] values)
        {

            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.Connection = this.conexion;
                cmd.CommandText = query;

                for (int pos = 0; pos < values.Length; pos += 2)
                {

                    cmd.Parameters.AddWithValue(values[pos], values[pos + 1]);

                }

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    return dt;

                }

            }

        }

        public int executeNonQuery(string query, params string[] values)
        {

            MySqlTransaction transaction = null;

            int resultado = 0;

            try
            {

                transaction = this.conexion.BeginTransaction();

                using (MySqlCommand cmd = new MySqlCommand())
                {

                    cmd.Connection = this.conexion;
                    cmd.Transaction = transaction;

                    cmd.CommandText = query;

                    for (int pos = 0; pos < values.Length; pos += 2)
                    {

                        cmd.Parameters.AddWithValue(values[pos], values[pos + 1]);

                    }

                    resultado = cmd.ExecuteNonQuery();

                    //MessageBox.Show(resultado.ToString());

                }

                transaction.Commit();

                return resultado;

            }
            catch (Exception ex)
            {

                if (transaction != null)
                {

                    transaction.Rollback();

                    MessageBox.Show("Rollback");

                }
                else
                {

                    MessageBox.Show(ex.Message);

                }

            }

            //No se ejecutó bien
            return -1;

        }

    }

}
