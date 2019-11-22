using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO.Ports;
using System.IO;

namespace ConectTest
{
    public partial class Config : Form
    {
        public static string stdComName;
        public static int stdBauldRate = 9600;
        public Config()
        {
            InitializeComponent();
            string[] p = SerialPort.GetPortNames();
            cbNomePorta.DataSource = p;
            txtBauldRate.Text = stdBauldRate.ToString();
            try
            {
                if (btnTest.Text == "Conectar")
                {
                    stdCom.PortName = cbNomePorta.SelectedValue.ToString();
                    stdCom.BaudRate = Int32.Parse(txtBauldRate.Text);
                    stdCom.Open();
                    btnTest.Text = "Desconectar";
                    //MessageBox.Show("Conexão efetuada!");
                }
                else
                {
                    stdCom.Close();
                    btnTest.Text = "Conectar";
                    //MessageBox.Show("Desconectado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            stdComName = cbNomePorta.SelectedValue.ToString();
            stdBauldRate = Int32.Parse(txtBauldRate.Text);
        }

        private void Config_Load(object sender, EventArgs e)
        {
            string[] p = SerialPort.GetPortNames();
            cbNomePorta.DataSource = p;
            txtBauldRate.Text = stdBauldRate.ToString();
        }
        private void Config_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                stdCom.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            txtBauldRate.Enabled = !txtBauldRate.Enabled;
            try
            {
                if (btnTest.Text == "Conectar")
                {
                    stdCom.PortName = cbNomePorta.SelectedValue.ToString();
                    stdCom.BaudRate = Int32.Parse(txtBauldRate.Text);
                    stdCom.Open();
                    btnTest.Text = "Desconectar";
                    stdComName = stdCom.PortName.ToString();
                    stdBauldRate = int.Parse(stdCom.BaudRate.ToString());
                    MessageBox.Show("Conexão efetuada!");
                    txtStatus.Text = stdComName +" configurada como padrão";
                }
                else
                {
                    stdCom.Close();
                    btnTest.Text = "Conectar";
                    MessageBox.Show("Desconectado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Banco_dados db = new Banco_dados();
            db.execute_query(db, "DELETE FROM Aula");
            db.execute_query(db, "DELETE FROM aluno_aula");
            if(ch_limp.Checked)
            {
                db.execute_query(db, "DELETE FROM Aluno");
                db.execute_query(db, "DELETE FROM Turma");
                db.execute_query(db, "DELETE FROM Professor");
            }
        }
    }
}