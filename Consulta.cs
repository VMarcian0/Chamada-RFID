using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConectTest
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_pesquisa_Click(object sender, EventArgs e)
        {
            Banco_dados db = new Banco_dados();
            String ra = txt_id.Text;
            String comando = "SELECT A.RA AS RA, (SELECT Nome from Turma WHERE Cod_turma IN (SELECT Cod_turma FROM Aluno_turma WHERE RA = '" + ra + "')" +
                                         " GROUP BY Nome) as Turma, ((SELECT COUNT(*) FROM Aula WHERE Cod_turma IN (SELECT Cod_turma FROM Aluno_turma WHERE RA" +
                                         " = '" + ra + "'))-(SELECT COUNT(*) FROM aluno_aula WHERE Cod_aula in (SELECT Cod_aula from Aula WHERE Cod_turma in (SELECT Cod_turma" +
                                         " from aluno_turma WHERE RA = '" + ra + "') )) ) AS Faltas FROM Aluno A, Aluno_aula B, Aluno_turma C, Aula D, Turma E WHERE A.RA = '" + ra + "' GROUP BY A.RA; ";
            db.get_grid_faltas(db, comando, gv_faltas);
        }
    }
}
