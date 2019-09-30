namespace ConectTest
{
    partial class Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_curso = new System.Windows.Forms.Label();
            this.txt_IdCard = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_read_RFID = new System.Windows.Forms.Button();
            this.check_professor = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_curso = new System.Windows.Forms.ComboBox();
            this.Id_name = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.Location = new System.Drawing.Point(163, 255);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(74, 25);
            this.btn_cadastro.TabIndex = 1;
            this.btn_cadastro.Text = "Cadastrar";
            this.btn_cadastro.UseVisualStyleBackColor = true;
            this.btn_cadastro.Click += new System.EventHandler(this.Btn_Enviar_Click);
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(10, 154);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(167, 20);
            this.txt_Nome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // lbl_curso
            // 
            this.lbl_curso.AutoSize = true;
            this.lbl_curso.Location = new System.Drawing.Point(7, 177);
            this.lbl_curso.Name = "lbl_curso";
            this.lbl_curso.Size = new System.Drawing.Size(34, 13);
            this.lbl_curso.TabIndex = 5;
            this.lbl_curso.Text = "Curso";
            // 
            // txt_IdCard
            // 
            this.txt_IdCard.Location = new System.Drawing.Point(10, 55);
            this.txt_IdCard.Name = "txt_IdCard";
            this.txt_IdCard.Size = new System.Drawing.Size(160, 20);
            this.txt_IdCard.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Id do Cartão";
            // 
            // btn_read_RFID
            // 
            this.btn_read_RFID.Location = new System.Drawing.Point(175, 50);
            this.btn_read_RFID.Name = "btn_read_RFID";
            this.btn_read_RFID.Size = new System.Drawing.Size(68, 25);
            this.btn_read_RFID.TabIndex = 8;
            this.btn_read_RFID.Text = "Ler Cartão";
            this.btn_read_RFID.UseVisualStyleBackColor = true;
            this.btn_read_RFID.Click += new System.EventHandler(this.Btn_read_RFID_Click);
            // 
            // check_professor
            // 
            this.check_professor.AutoSize = true;
            this.check_professor.Location = new System.Drawing.Point(17, 19);
            this.check_professor.Name = "check_professor";
            this.check_professor.Size = new System.Drawing.Size(70, 17);
            this.check_professor.TabIndex = 9;
            this.check_professor.Text = "Professor";
            this.check_professor.UseVisualStyleBackColor = true;
            this.check_professor.CheckedChanged += new System.EventHandler(this.Check_professor_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.CausesValidation = false;
            this.groupBox1.Controls.Add(this.combo_curso);
            this.groupBox1.Controls.Add(this.Id_name);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_curso);
            this.groupBox1.Controls.Add(this.txt_Nome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.check_professor);
            this.groupBox1.Controls.Add(this.btn_read_RFID);
            this.groupBox1.Controls.Add(this.txt_IdCard);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 237);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // combo_curso
            // 
            this.combo_curso.FormattingEnabled = true;
            this.combo_curso.Location = new System.Drawing.Point(10, 193);
            this.combo_curso.Name = "combo_curso";
            this.combo_curso.Size = new System.Drawing.Size(167, 21);
            this.combo_curso.TabIndex = 12;
            this.combo_curso.SelectedIndexChanged += new System.EventHandler(this.Combo_curso_SelectedIndexChanged);
            // 
            // Id_name
            // 
            this.Id_name.AutoSize = true;
            this.Id_name.Location = new System.Drawing.Point(6, 99);
            this.Id_name.Name = "Id_name";
            this.Id_name.Size = new System.Drawing.Size(22, 13);
            this.Id_name.TabIndex = 11;
            this.Id_name.Text = "RA";
            this.Id_name.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(10, 115);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(167, 20);
            this.txt_id.TabIndex = 10;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(22, 255);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(74, 25);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 292);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btn_cadastro);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_cadastro;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_curso;
        private System.Windows.Forms.TextBox txt_IdCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_read_RFID;
        private System.Windows.Forms.CheckBox check_professor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Id_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox combo_curso;
    }
}

