using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using System.IO.Ports;

namespace ConectTest
{
    class Banco_dados
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>

        public MySqlConnection con =  new MySqlConnection("server=localhost;port=3307;User Id=root;database=db_teste;password=usbw;");
        public static String retornoNome = "";
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

        public void get_cb(Banco_dados db,String comando, ComboBox cb)
        {
            
            db.Conect_to_database(db.con);
            MySqlCommand edh = new MySqlCommand(comando, db.con);
            MySqlDataReader myReader;
            myReader = edh.ExecuteReader();
            while (myReader.Read())
            {
                cb.Items.Add(myReader.GetString(0));
            }
        }

        public void execute_query(Banco_dados db, String comando)
        {
            Console.WriteLine(comando);
            db.Conect_to_database(db.con);
            MySqlCommand edh = new MySqlCommand(comando, db.con);
            edh.ExecuteNonQuery();
            db.Close_database(db.con);
        }
        public void get_grid(Banco_dados db, String comando, DataGridView cb, SerialPort serialListener)
        {
            db.Conect_to_database(db.con);
            string name = "";
            MySqlCommand edh = new MySqlCommand(comando, db.con);
            MySqlDataReader myReader;
            myReader = edh.ExecuteReader();
            DataTable dtb1 = new DataTable();
            DataColumn ra = new DataColumn();
            DataColumn nome = new DataColumn();
            ra.ColumnName = "Ra";
            nome.ColumnName = "Nome";
            dtb1.Columns.Add(ra);
            dtb1.Columns.Add(nome);
            while (myReader.Read())
            {
                DataRow row = dtb1.NewRow();
                row["Ra"] = myReader.GetString(0);
                row["nome"] = myReader.GetString(1);
                name = myReader.GetString(0).ToString();
                dtb1.Rows.Add(row);
            }
            serialListener.WriteLine("Chamada Ok!\r"+name); //Imprime que a chamada está OK junto com o RA do aluno
            cb.DataSource = dtb1;
        }
        public void get_grid_faltas(Banco_dados db, String comando, DataGridView cb)
        {
            db.Conect_to_database(db.con);
            MySqlCommand edh = new MySqlCommand(comando, db.con);
            MySqlDataReader myReader;
            myReader = edh.ExecuteReader();
            DataTable dtb1 = new DataTable();
            DataColumn turma = new DataColumn();
            DataColumn faltas = new DataColumn();
            turma.ColumnName = "Turma";
            faltas.ColumnName = "Faltas";
            dtb1.Columns.Add(turma);
            dtb1.Columns.Add(faltas);
            while (myReader.Read())
            {
                DataRow row = dtb1.NewRow();
                row["Turma"] = myReader.GetString(1);
                row["Faltas"] = myReader.GetString(2);
                
                dtb1.Rows.Add(row);
            }
            cb.DataSource = dtb1;
        }
        public void chamada_aluno(Banco_dados db,String recebido, TextBox txt_id, DateTimePicker data_chamada, ComboBox cb_turma, DataGridView data_grid, SerialPort serialListener)
        {
            String cod_professor = txt_id.Text;
            String data = (data_chamada.Value.Day.ToString() + "/" + data_chamada.Value.Month.ToString() + "/" + data_chamada.Value.Year.ToString());
            String turma = cb_turma.Text;
            String comando = ("INSERT INTO Aluno_aula (Cod_aula, RA) " +
                              "VALUES ((SELECT Cod_aula " +
                              "FROM Aula WHERE Cod_Professor = (Select Cod_Professor from Professor where RFID = '"+cod_professor+"')" +
                              " AND Data = '" + data + "'" +
                              " AND Cod_turma = (SELECT Cod_turma FROM Turma WHERE Nome = '" + turma + "'))," +
                              " (SELECT RA FROM Aluno WHERE RFID = '" + recebido + "'))");
            string query = ("SELECT RA as RA, Nome as Nome FROM Aluno" +
                                    " WHERE RA in (SELECT RA FROM Aluno_aula WHERE Cod_aula = (SELECT MAX(Cod_aula)) " +
                                    " ORDER BY Cod_aula)");
            try
            {
                db.execute_query(db,comando);
                Banco_dados abacate = new Banco_dados();
                abacate.get_grid(abacate, query, data_grid,serialListener);
            }catch (MySqlException e)
            {
                Console.WriteLine("Erro @Chamada Aluno : "+ e);
            }
        }
        public void iniciar_chamada(TextBox txt_id, ComboBox cb_turma, DateTimePicker data_chamada, Banco_dados db)
        {
            
            try
            {
                String cod_professor = txt_id.Text;
                String cod_turma = cb_turma.Text;
                String data = (data_chamada.Value.Day.ToString() + "/" + data_chamada.Value.Month.ToString() + "/" + data_chamada.Value.Year.ToString());
                string comando = "INSERT INTO Aula (Cod_professor, Data, Cod_turma)" +
                                 " VALUES ((Select Cod_Professor from Professor where RFID = '"+cod_professor+"') , '" + data + "'," +
                                 " (SELECT Cod_turma FROM Turma WHERE Nome ='" + cod_turma + "'))";
                db.execute_query(db, comando);
            }catch(MySqlException e)
            {
                MessageBox.Show("Impossível iniciar chamada");
                Console.WriteLine("Erro @Iniciar chamada : " + e);
            }
        }

    }
}
