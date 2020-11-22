namespace Academy.Bank
{
    partial class ManageCCForm
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
            this.lbl_CC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_fondiInsuff = new System.Windows.Forms.Label();
            this.btn_versa = new System.Windows.Forms.Button();
            this.btn_Preleva = new System.Windows.Forms.Button();
            this.txt_importo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_esegui_bonifico = new System.Windows.Forms.Button();
            this.txt_beneficiario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_importo_bonifico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_displaySaldo = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lbl_fondiInsuff2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_CC
            // 
            this.lbl_CC.AutoSize = true;
            this.lbl_CC.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CC.ForeColor = System.Drawing.Color.Blue;
            this.lbl_CC.Location = new System.Drawing.Point(826, 46);
            this.lbl_CC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CC.Name = "lbl_CC";
            this.lbl_CC.Size = new System.Drawing.Size(0, 58);
            this.lbl_CC.TabIndex = 0;
            this.lbl_CC.Click += new System.EventHandler(this.lbl_CC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestione Conto Corrente Numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "saldo ";
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saldo.Location = new System.Drawing.Point(206, 143);
            this.lbl_saldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(0, 46);
            this.lbl_saldo.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.lbl_fondiInsuff);
            this.panel1.Controls.Add(this.btn_versa);
            this.panel1.Controls.Add(this.btn_Preleva);
            this.panel1.Controls.Add(this.txt_importo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(36, 249);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 251);
            this.panel1.TabIndex = 4;
            // 
            // lbl_fondiInsuff
            // 
            this.lbl_fondiInsuff.AutoSize = true;
            this.lbl_fondiInsuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fondiInsuff.ForeColor = System.Drawing.Color.Red;
            this.lbl_fondiInsuff.Location = new System.Drawing.Point(44, 215);
            this.lbl_fondiInsuff.Name = "lbl_fondiInsuff";
            this.lbl_fondiInsuff.Size = new System.Drawing.Size(0, 29);
            this.lbl_fondiInsuff.TabIndex = 12;
            // 
            // btn_versa
            // 
            this.btn_versa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_versa.Location = new System.Drawing.Point(305, 142);
            this.btn_versa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_versa.Name = "btn_versa";
            this.btn_versa.Size = new System.Drawing.Size(181, 68);
            this.btn_versa.TabIndex = 8;
            this.btn_versa.Text = "Versa";
            this.btn_versa.UseVisualStyleBackColor = true;
            this.btn_versa.Click += new System.EventHandler(this.btn_versa_Click);
            // 
            // btn_Preleva
            // 
            this.btn_Preleva.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Preleva.Location = new System.Drawing.Point(36, 142);
            this.btn_Preleva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Preleva.Name = "btn_Preleva";
            this.btn_Preleva.Size = new System.Drawing.Size(175, 68);
            this.btn_Preleva.TabIndex = 7;
            this.btn_Preleva.Text = "Preleva";
            this.btn_Preleva.UseVisualStyleBackColor = true;
            this.btn_Preleva.Click += new System.EventHandler(this.btn_Preleva_Click);
            // 
            // txt_importo
            // 
            this.txt_importo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_importo.Location = new System.Drawing.Point(248, 34);
            this.txt_importo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_importo.Name = "txt_importo";
            this.txt_importo.Size = new System.Drawing.Size(247, 53);
            this.txt_importo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "importo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.btn_esegui_bonifico);
            this.panel2.Controls.Add(this.txt_beneficiario);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_importo_bonifico);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(723, 249);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 251);
            this.panel2.TabIndex = 5;
            // 
            // btn_esegui_bonifico
            // 
            this.btn_esegui_bonifico.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_esegui_bonifico.Location = new System.Drawing.Point(45, 183);
            this.btn_esegui_bonifico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_esegui_bonifico.Name = "btn_esegui_bonifico";
            this.btn_esegui_bonifico.Size = new System.Drawing.Size(545, 63);
            this.btn_esegui_bonifico.TabIndex = 9;
            this.btn_esegui_bonifico.Text = "Esegui Bonifico";
            this.btn_esegui_bonifico.UseVisualStyleBackColor = true;
            this.btn_esegui_bonifico.Click += new System.EventHandler(this.btn_esegui_bonifico_Click);
            // 
            // txt_beneficiario
            // 
            this.txt_beneficiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_beneficiario.Location = new System.Drawing.Point(274, 106);
            this.txt_beneficiario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_beneficiario.Name = "txt_beneficiario";
            this.txt_beneficiario.Size = new System.Drawing.Size(339, 53);
            this.txt_beneficiario.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 46);
            this.label6.TabIndex = 10;
            this.label6.Text = "beneficiario";
            // 
            // txt_importo_bonifico
            // 
            this.txt_importo_bonifico.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_importo_bonifico.Location = new System.Drawing.Point(276, 28);
            this.txt_importo_bonifico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_importo_bonifico.Name = "txt_importo_bonifico";
            this.txt_importo_bonifico.Size = new System.Drawing.Size(337, 53);
            this.txt_importo_bonifico.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "importo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1030, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 46);
            this.label5.TabIndex = 7;
            this.label5.Text = "BONIFICO";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Location = new System.Drawing.Point(214, 613);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(975, 304);
            this.panel3.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(605, 550);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 46);
            this.label7.TabIndex = 9;
            this.label7.Text = "MOVIMENTI";
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(1323, 613);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(204, 68);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_displaySaldo
            // 
            this.lbl_displaySaldo.AutoSize = true;
            this.lbl_displaySaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_displaySaldo.ForeColor = System.Drawing.Color.Blue;
            this.lbl_displaySaldo.Location = new System.Drawing.Point(240, 153);
            this.lbl_displaySaldo.Name = "lbl_displaySaldo";
            this.lbl_displaySaldo.Size = new System.Drawing.Size(0, 29);
            this.lbl_displaySaldo.TabIndex = 11;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // lbl_fondiInsuff2
            // 
            this.lbl_fondiInsuff2.AutoSize = true;
            this.lbl_fondiInsuff2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fondiInsuff2.ForeColor = System.Drawing.Color.Red;
            this.lbl_fondiInsuff2.Location = new System.Drawing.Point(772, 215);
            this.lbl_fondiInsuff2.Name = "lbl_fondiInsuff2";
            this.lbl_fondiInsuff2.Size = new System.Drawing.Size(0, 29);
            this.lbl_fondiInsuff2.TabIndex = 13;
            // 
            // ManageCCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1572, 814);
            this.Controls.Add(this.lbl_fondiInsuff2);
            this.Controls.Add(this.lbl_displaySaldo);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_saldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_CC);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageCCForm";
            this.Text = "ManageCCForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_versa;
        private System.Windows.Forms.Button btn_Preleva;
        private System.Windows.Forms.TextBox txt_importo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_esegui_bonifico;
        private System.Windows.Forms.TextBox txt_beneficiario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_importo_bonifico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_displaySaldo;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lbl_fondiInsuff;
        private System.Windows.Forms.Label lbl_fondiInsuff2;
    }
}