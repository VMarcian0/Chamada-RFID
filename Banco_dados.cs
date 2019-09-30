using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace ConectTest
{
    class Banco_dados
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>

        public MySqlConnection con = null;
        public  void Conect_to_database(MySqlConnection con)
        {
            try
            {
                this.con = new MySqlConnection("server=localhost;port=3307;User Id=root;database=db_teste;password=usbw;");
                this.con.Open();
                //MessageBox.Show("Conectado");
               
            }
            catch
            {
                MessageBox.Show("Não Conectado");
            }
        }
        public void Close_database(MySqlConnection con)
        {
            try
            {

                this.con.Close();
                //MessageBox.Show("Desconectado");
            }
            catch
            {
                //MessageBox.Show("Não Desconectado");
            }
        }
       
    }
}
