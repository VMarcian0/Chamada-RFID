namespace ConectTest
{
    partial class Consulta
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.iD_label = new System.Windows.Forms.Label();
            this.gv_faltas = new System.Windows.Forms.DataGridView();
            this.btn_pesquisa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_faltas)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(53, 29);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(130, 20);
            this.txt_id.TabIndex = 0;
            // 
            // iD_label
            // 
            this.iD_label.AutoSize = true;
            this.iD_label.Location = new System.Drawing.Point(12, 32);
            this.iD_label.Name = "iD_label";
            this.iD_label.Size = new System.Drawing.Size(22, 13);
            this.iD_label.TabIndex = 1;
            this.iD_label.Text = "RA";
            this.iD_label.Click += new System.EventHandler(this.Label1_Click);
            // 
            // gv_faltas
            // 
            this.gv_faltas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_faltas.Location = new System.Drawing.Point(28, 76);
            this.gv_faltas.Name = "gv_faltas";
            this.gv_faltas.Size = new System.Drawing.Size(245, 312);
            this.gv_faltas.TabIndex = 2;
            // 
            // btn_pesquisa
            // 
            this.btn_pesquisa.Location = new System.Drawing.Point(198, 27);
            this.btn_pesquisa.Name = "btn_pesquisa";
            this.btn_pesquisa.Size = new System.Drawing.Size(75, 23);
            this.btn_pesquisa.TabIndex = 3;
            this.btn_pesquisa.Text = "Pesquisar";
            this.btn_pesquisa.UseVisualStyleBackColor = true;
            this.btn_pesquisa.Click += new System.EventHandler(this.Btn_pesquisa_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 450);
            this.Controls.Add(this.btn_pesquisa);
            this.Controls.Add(this.gv_faltas);
            this.Controls.Add(this.iD_label);
            this.Controls.Add(this.txt_id);
            this.Name = "Consulta";
            this.Text = "Faltas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_faltas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label iD_label;
        private System.Windows.Forms.DataGridView gv_faltas;
        private System.Windows.Forms.Button btn_pesquisa;
    }
}