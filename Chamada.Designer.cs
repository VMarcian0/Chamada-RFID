namespace ConectTest
{
    partial class Chamada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCadastraTurma = new System.Windows.Forms.Button();
            this.ch_turma = new System.Windows.Forms.CheckBox();
            this.data_chamada = new System.Windows.Forms.DateTimePicker();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btnChama = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_turma = new System.Windows.Forms.ComboBox();
            this.data_grid = new System.Windows.Forms.DataGridView();
            this.serialListener = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCadastraTurma);
            this.groupBox1.Controls.Add(this.ch_turma);
            this.groupBox1.Controls.Add(this.data_chamada);
            this.groupBox1.Controls.Add(this.btn_pesquisar);
            this.groupBox1.Controls.Add(this.lbl_id);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.btnChama);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_turma);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuração de Sala";
            // 
            // btnCadastraTurma
            // 
            this.btnCadastraTurma.Location = new System.Drawing.Point(9, 121);
            this.btnCadastraTurma.Name = "btnCadastraTurma";
            this.btnCadastraTurma.Size = new System.Drawing.Size(167, 23);
            this.btnCadastraTurma.TabIndex = 10;
            this.btnCadastraTurma.Text = "Cadastra Turma";
            this.btnCadastraTurma.UseVisualStyleBackColor = true;
            this.btnCadastraTurma.Click += new System.EventHandler(this.btnCadastraTurma_Click_1);
            // 
            // ch_turma
            // 
            this.ch_turma.AutoSize = true;
            this.ch_turma.Location = new System.Drawing.Point(11, 130);
            this.ch_turma.Name = "ch_turma";
            this.ch_turma.Size = new System.Drawing.Size(100, 17);
            this.ch_turma.TabIndex = 9;
            this.ch_turma.Text = "Cadastrar turma";
            this.ch_turma.UseVisualStyleBackColor = true;
            this.ch_turma.Visible = false;
            this.ch_turma.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // data_chamada
            // 
            this.data_chamada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_chamada.Location = new System.Drawing.Point(11, 152);
            this.data_chamada.Name = "data_chamada";
            this.data_chamada.Size = new System.Drawing.Size(165, 20);
            this.data_chamada.TabIndex = 8;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(90, 65);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(86, 23);
            this.btn_pesquisar.TabIndex = 7;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Visible = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.Btn_pesquisar_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(8, 20);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(79, 13);
            this.lbl_id.TabIndex = 6;
            this.lbl_id.Text = "RFID Professor";
            this.lbl_id.Click += new System.EventHandler(this.Label3_Click_1);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(11, 39);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(165, 20);
            this.txt_id.TabIndex = 5;
            // 
            // btnChama
            // 
            this.btnChama.Location = new System.Drawing.Point(90, 178);
            this.btnChama.Name = "btnChama";
            this.btnChama.Size = new System.Drawing.Size(86, 23);
            this.btnChama.TabIndex = 4;
            this.btnChama.Text = "Iniciar";
            this.btnChama.UseVisualStyleBackColor = true;
            this.btnChama.Click += new System.EventHandler(this.btnChama_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Turma";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // cb_turma
            // 
            this.cb_turma.FormattingEnabled = true;
            this.cb_turma.Location = new System.Drawing.Point(9, 94);
            this.cb_turma.Name = "cb_turma";
            this.cb_turma.Size = new System.Drawing.Size(165, 21);
            this.cb_turma.TabIndex = 0;
            this.cb_turma.SelectedIndexChanged += new System.EventHandler(this.Cb_turma_SelectedIndexChanged);
            // 
            // data_grid
            // 
            this.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid.Location = new System.Drawing.Point(216, 12);
            this.data_grid.Name = "data_grid";
            this.data_grid.Size = new System.Drawing.Size(287, 214);
            this.data_grid.TabIndex = 1;
            this.data_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_CellContentClick);
            // 
            // serialListener
            // 
            this.serialListener.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialListener_DataReceived);
            // 
            // Chamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 262);
            this.Controls.Add(this.data_grid);
            this.Controls.Add(this.groupBox1);
            this.Name = "Chamada";
            this.Text = "Chamada";
            this.Load += new System.EventHandler(this.Chamada_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_turma;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.DateTimePicker data_chamada;
        private System.Windows.Forms.DataGridView data_grid;
        public System.IO.Ports.SerialPort serialListener;
        private System.Windows.Forms.CheckBox ch_turma;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btnCadastraTurma;
    }
}