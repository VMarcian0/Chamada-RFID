namespace ConectTest
{
    partial class Config
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
            this.cbNomePorta = new System.Windows.Forms.ComboBox();
            this.txtBauldRate = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stdCom = new System.IO.Ports.SerialPort(this.components);
            this.Btn_limpar = new System.Windows.Forms.Button();
            this.ch_limp = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbNomePorta
            // 
            this.cbNomePorta.FormattingEnabled = true;
            this.cbNomePorta.Location = new System.Drawing.Point(21, 53);
            this.cbNomePorta.Name = "cbNomePorta";
            this.cbNomePorta.Size = new System.Drawing.Size(159, 21);
            this.cbNomePorta.TabIndex = 0;
            // 
            // txtBauldRate
            // 
            this.txtBauldRate.Location = new System.Drawing.Point(21, 100);
            this.txtBauldRate.Name = "txtBauldRate";
            this.txtBauldRate.Size = new System.Drawing.Size(159, 20);
            this.txtBauldRate.TabIndex = 1;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(93, 114);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Testar";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome da Porta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Taxa de Tranferência";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(21, 155);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(159, 20);
            this.txtStatus.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 176);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arduino";
            // 
            // Btn_limpar
            // 
            this.Btn_limpar.Location = new System.Drawing.Point(21, 194);
            this.Btn_limpar.Name = "Btn_limpar";
            this.Btn_limpar.Size = new System.Drawing.Size(80, 20);
            this.Btn_limpar.TabIndex = 8;
            this.Btn_limpar.Text = "Limpar DB";
            this.Btn_limpar.UseVisualStyleBackColor = true;
            this.Btn_limpar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ch_limp
            // 
            this.ch_limp.AutoSize = true;
            this.ch_limp.Location = new System.Drawing.Point(108, 196);
            this.ch_limp.Name = "ch_limp";
            this.ch_limp.Size = new System.Drawing.Size(71, 17);
            this.ch_limp.TabIndex = 9;
            this.ch_limp.Text = "Full clean";
            this.ch_limp.UseVisualStyleBackColor = true;
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 216);
            this.Controls.Add(this.ch_limp);
            this.Controls.Add(this.Btn_limpar);
            this.Controls.Add(this.cbNomePorta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBauldRate);
            this.Controls.Add(this.groupBox1);
            this.Name = "Config";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNomePorta;
        private System.Windows.Forms.TextBox txtBauldRate;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.IO.Ports.SerialPort stdCom;
        private System.Windows.Forms.Button Btn_limpar;
        private System.Windows.Forms.CheckBox ch_limp;
    }
}