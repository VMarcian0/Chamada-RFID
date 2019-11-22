using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConectTest
{
    public partial class Chamada : Form
    {
        private static string recebido = "";
        

        public Chamada()
        {
            InitializeComponent();
            

        }

        private void btnChama_Click(object sender, EventArgs e)
        {
            if(btnChama.Text == "Iniciar")
            {
                try
                {
                    Banco_dados db = new Banco_dados();
                    if(ch_turma.Checked)
                    {
                        String id = txt_id.Text;
                        String nome = cb_turma.Text;
                        String comando = "INSERT INTO Turma (Cod_professor, Nome) VALUES ((Select Cod_Professor from Professor where RFID = '"+id+"'), '" + nome+"');";
                        db.execute_query(db, comando);
                    }
                    db.iniciar_chamada(txt_id, cb_turma, data_chamada, db);
                    btnChama.Text = "Terminar";
                }
                catch (Exception E)
                {
                    throw new Exception("Erro: " + E);
                }
            }
            else if(btnChama.Text == "Terminar")
            {
                try
                {
                    serialListener.Close();
                    Close();
                    btnChama.Text = "Iniciar";
                }
                catch (Exception E)
                {
                    throw new Exception("Erro: " + E);
                }
            }
        }
        //Casso arduino magicamente mande uma string para o programa:
        private void serialListener_DataReceived(object sender,
            SerialDataReceivedEventArgs e)
        {
            if (btn_pesquisar.Text.Contains("Selecionado"))
            {
                Invoke(new EventHandler(recebeString));
            }
            else if (btnChama.Text.Contains("Iniciar"))
            {
                Invoke(new EventHandler(escreveId));
            }
        }

        private void escreveId(object o, EventArgs e)
        {
            String recebido = serialListener.ReadLine().Replace("\r", "").ToUpper();
            txt_id.Text = recebido;
            try
            {
                String id_professor = txt_id.Text;
                Banco_dados db = new Banco_dados();
                string comando = "SELECT Nome FROM turma WHERE Cod_Professor = (Select Cod_Professor from Professor where RFID = '" + id_professor + "')";
                //string comando = "SELECT Nome FROM Turma WHERE Cod_professor = " + id_professor + " ORDER BY Nome";
                db.get_cb(db, comando, cb_turma);
                if (cb_turma.Items.Count == 0)
                {
                    MessageBox.Show("Código do professor não encontrado ou professor sem aulas cadastradas");
                    btn_pesquisar.Visible = true;
                }
                else
                {
                    MessageBox.Show("Professor Selecionado");
                    btn_pesquisar.Text = "Selecionado";
                    serialListener.DiscardInBuffer();
                }
            }
            catch
            {
                MessageBox.Show("Erro ao pesquisar Professor");
            }
        }

        private void recebeString(object o, EventArgs e)
        {
            String recebido = serialListener.ReadLine().Replace("\r", "").ToUpper();//FUNCÇÃO mágica SQL RETORNANDO STRING PARA PRINTAR NO LCD DO ARDUINO
            Console.WriteLine(recebido);
            
            Banco_dados db = new Banco_dados();//isso aqui é importante?
            try
            {
                db.chamada_aluno(db, recebido, txt_id, data_chamada, cb_turma, data_grid, serialListener);
                String nome = cb_turma.Text;
                String comando = "INSERT INTO Aluno_turma(RA, Cod_turma) VALUES((SELECT RA FROM Aluno WHERE RFID = '"+recebido+"')," +
                                 " (SELECT Cod_turma FROM Turma WHERE Nome = '"+nome+"'))";
                db.execute_query(db, comando);
                serialListener.WriteLine(recebido);
            }
            catch(Exception a)
            {
                Console.Write(a);
            }
            serialListener.DiscardInBuffer();
            
        }

        private void Chamada__FormClosing(object sender, EventArgs e)
        {
            try
            {
                serialListener.Close();
            }
            catch (Exception E)
            {
                throw new Exception("Erro: " + E);
            }
            /*
            Sempre bom lembrar que é importante fechar as portas quando sair
                        ⣿⣿⣿⡇⠄⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
                        ⣿⣿⣿⡇⠄⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
                        ⣿⣿⣿⡇⠄⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
                        ⣿⣿⣿⡇⠄⣿⣿⣿⡿⠟⠋⣉⣉⣉⡙⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
                        ⣿⣿⣿⠃⠄⠹⠟⣡⣶⡿⢟⣛⣛⡻⢿⣦⣩⣤⣤⣤⣬⡉⢻⣿⣿⣿⣿⣿⣿⣿
                        ⣿⣿⣿⠄⢀⢤⣾⣿⣿⣿⣿⡿⠿⠿⠿⢮⡃⣛⣛⡻⠿⢿⠈⣿⣿⣿⣿⣿⣿⣿
                        ⣿⡟⢡⣴⣯⣿⣿⣿⣉⠤⣤⣭⣶⣶⣶⣮⣔⡈⠛⠛⠛⢓⠦⠈⢻⣿⣿⣿⣿⣿
                        ⠏⣠⣿⣿⣿⣿⣿⣿⣿⣯⡪⢛⠿⢿⣿⣿⣿⡿⣼⣿⣿⣿⣶⣮⣄⠙⣿⣿⣿⣿
                        ⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣾⡭⠴⣶⣶⣽⣽⣛⡿⠿⠿⠿⠿⠇⣿⣿⣿⣿
                        ⣿⣿⣿⣿⣿⣿⣿⠿⠿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣝⣛⢛⡛⢋⣥⣴⣿⣿⣿⣿⣿
                        ⣿⣿⣿⣿⣿⢿⠱⣿⣿⣛⠾⣭⣛⡿⢿⣿⣿⣿⣿⣿⣿⣿⡀⣿⣿⣿⣿⣿⣿⣿
                        ⠑⠽⡻⢿⣿⣮⣽⣷⣶⣯⣽⣳⠮⣽⣟⣲⠯⢭⣿⣛⣛⣿⡇⢸⣿⣿⣿⣿⣿⣿
                        ⠄⠄⠈⠑⠊⠉⠟⣻⠿⣿⣿⣿⣿⣷⣾⣭⣿⣛⠷⠶⠶⠂⣴⣿⣿⣿⣿⣿⣿⣿
                        ⠄⠄⠄⠄⠄⠄⠄⠄⠁⠙⠒⠙⠯⠍⠙⢉⣉⣡⣶⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
                        ⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠙⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
            */
        }

        private void Chamada_Load(object sender, EventArgs e)
        {
            serialListener.PortName = Config.stdComName;
            serialListener.BaudRate = Config.stdBauldRate;
            try
            {
                serialListener.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro Comunicação Serial:: "+ ex);
            }
            //Ao abrir o formulário está carregando as configurações padrão da porta serial
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Txt_id_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void Cb_turma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Btn_pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                String id_professor = txt_id.Text;
                Banco_dados db = new Banco_dados();
                string comando = "SELECT Nome FROM turma WHERE Cod_Professor = (Select Cod_Professor from Professor where RFID = '" + id_professor + "')";
                //string comando = "SELECT Nome FROM Turma WHERE Cod_professor = " + id_professor + " ORDER BY Nome";
                db.get_cb(db, comando, cb_turma);
                if (cb_turma.Items.Count == 0)
                {
                    MessageBox.Show("Código do professor não encontrado ou professor sem aulas cadastradas");
                }
                else
                {
                    MessageBox.Show("Professor Selecionado");
                    btn_pesquisar.Text = "Selecionado";
                }
            }catch
            {
                MessageBox.Show("Erro ao pesquisar Professor");
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastraTurma_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastraTurma_Click_1(object sender, EventArgs e)
        {
            Banco_dados db = new Banco_dados();
            String id = txt_id.Text;
            String nome = cb_turma.Text;
            String comando = "INSERT INTO Turma (Cod_professor, Nome) VALUES ((Select Cod_Professor from Professor where RFID = '" + id + "'), '" + nome + "');";
            try
            {
                db.execute_query(db, comando);
            }
            catch(Exception pp)
            {
                MessageBox.Show("Impossível Cadastrar");
            }
        }

        private void data_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
