using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConectTest
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            
            InitializeComponent();
            Banco_dados db = new Banco_dados();
            db.Conect_to_database(db.con);
            string comando = "SELECT Nome FROM Curso ORDER BY Cod_curso";
            MySqlCommand edh = new MySqlCommand(comando, db.con);
            MySqlDataReader myReader;
            myReader = edh.ExecuteReader();
            while (myReader.Read())
            {
                combo_curso.Items.Add(myReader.GetString(0));
            }
        }

        private void Btn_ConectaBD_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;port=3307;User Id=root;database=db_teste;password=usbw;");
                con.Open();
                MessageBox.Show("Conectado");
                con.Close();
            }
            catch
            {
                MessageBox.Show("Não Conecntado");
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
                    }

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            Banco_dados db = new Banco_dados();
            db.Conect_to_database(db.con);
            String comando = null;
            if(check_professor.Checked)
            {
                Professor p = new Professor(txt_Nome.Text, Int32.Parse(txt_id.Text), txt_IdCard.Text);
                comando = "INSERT INTO Professor (Cod_professor, RFID, Nome) VALUES ("+p.Id+", '"+p.RFID+"', '"+p.Nome+"')";
                Console.WriteLine(comando);

            }
            else
            {
                
                Aluno a = new Aluno(txt_Nome.Text,Int32.Parse(txt_id.Text), txt_IdCard.Text, (combo_curso.Items.IndexOf(combo_curso.Text)+1));
                comando = "INSERT INTO Aluno (RA, Cod_curso, RFID, Nome) VALUES ("+a.RA+", "+a.cod_curso+", '"+a.RFID+"', '"+a.Nome+"')";
                Console.WriteLine(comando);
            }
            MySqlCommand edh = new MySqlCommand(comando,db.con);
            try
            {
                edh.ExecuteNonQuery();
                db.Close_database(db.con);
                MessageBox.Show("Cadastro realizado com sucesso");
            }
            catch {
                MessageBox.Show("Erro ao fazer cadastro");
                db.Close_database(db.con);
                
            }
            //db.Close_database(db.con);
            
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_read_RFID_Click(object sender, EventArgs e)
        {
            Arduino a = new Arduino(Config.stdComName,Config.stdBauldRate);
            txt_IdCard.Text = a.Ler().ToString();
        }

        private void Check_professor_CheckedChanged(object sender, EventArgs e)
        {
            if(check_professor.Checked)
            {
                Id_name.Text = "ID";
                combo_curso.Visible = false;
                lbl_curso.Visible = false;
                
            }else
            {
                Id_name.Text = "RA";
                combo_curso.Visible = true;
                lbl_curso.Visible = true;
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Combo_curso_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
