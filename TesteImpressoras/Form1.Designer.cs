namespace TesteImpressoras
{
    partial class Form1
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
            this.btnGetTotalPag = new System.Windows.Forms.Button();
            this.btnTotalPagMono = new System.Windows.Forms.Button();
            this.txtboxOid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.checkBoxNuloCrip = new System.Windows.Forms.CheckBox();
            this.checkBoxDes = new System.Windows.Forms.CheckBox();
            this.checkBoxAes = new System.Windows.Forms.CheckBox();
            this.checkBoxNuloAut = new System.Windows.Forms.CheckBox();
            this.checkBoxMd5 = new System.Windows.Forms.CheckBox();
            this.checkBoxSha1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxSenhaCrip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxSenhaAut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxUsuarioSnmp = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.configSMTPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetTotalPag
            // 
            this.btnGetTotalPag.Location = new System.Drawing.Point(792, 13);
            this.btnGetTotalPag.Name = "btnGetTotalPag";
            this.btnGetTotalPag.Size = new System.Drawing.Size(151, 23);
            this.btnGetTotalPag.TabIndex = 0;
            this.btnGetTotalPag.Text = "Obter Info Mib";
            this.btnGetTotalPag.UseVisualStyleBackColor = true;
            this.btnGetTotalPag.Click += new System.EventHandler(this.btnGetMibInfo_Click);
            // 
            // btnTotalPagMono
            // 
            this.btnTotalPagMono.Location = new System.Drawing.Point(792, 54);
            this.btnTotalPagMono.Name = "btnTotalPagMono";
            this.btnTotalPagMono.Size = new System.Drawing.Size(151, 23);
            this.btnTotalPagMono.TabIndex = 1;
            this.btnTotalPagMono.Text = "Obter Info Mib V3";
            this.btnTotalPagMono.UseVisualStyleBackColor = true;
            this.btnTotalPagMono.Click += new System.EventHandler(this.btnGetMibInfoSnmpV3_Click);
            // 
            // txtboxOid
            // 
            this.txtboxOid.Location = new System.Drawing.Point(16, 126);
            this.txtboxOid.Name = "txtboxOid";
            this.txtboxOid.Size = new System.Drawing.Size(152, 20);
            this.txtboxOid.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "OID";
            // 
            // txtBoxIp
            // 
            this.txtBoxIp.Location = new System.Drawing.Point(16, 57);
            this.txtBoxIp.Name = "txtBoxIp";
            this.txtBoxIp.Size = new System.Drawing.Size(152, 20);
            this.txtBoxIp.TabIndex = 2;
            this.txtBoxIp.TextChanged += new System.EventHandler(this.txtBoxIp_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btnEnviarEmail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnTotalPagMono);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGetTotalPag);
            this.panel1.Controls.Add(this.txtboxOid);
            this.panel1.Controls.Add(this.txtBoxIp);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 165);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "SNMP V3";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 41);
            this.label4.TabIndex = 7;
            this.label4.Text = "USUÁRIO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Controls.Add(this.checkBoxNuloCrip);
            this.panel2.Controls.Add(this.checkBoxDes);
            this.panel2.Controls.Add(this.checkBoxAes);
            this.panel2.Controls.Add(this.checkBoxNuloAut);
            this.panel2.Controls.Add(this.checkBoxMd5);
            this.panel2.Controls.Add(this.checkBoxSha1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtBoxSenhaCrip);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtBoxSenhaAut);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtBoxUsuarioSnmp);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(946, 271);
            this.panel2.TabIndex = 8;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(868, 245);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 23;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // checkBoxNuloCrip
            // 
            this.checkBoxNuloCrip.AutoSize = true;
            this.checkBoxNuloCrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNuloCrip.Location = new System.Drawing.Point(628, 207);
            this.checkBoxNuloCrip.Name = "checkBoxNuloCrip";
            this.checkBoxNuloCrip.Size = new System.Drawing.Size(76, 24);
            this.checkBoxNuloCrip.TabIndex = 22;
            this.checkBoxNuloCrip.Text = "NULO";
            this.checkBoxNuloCrip.UseVisualStyleBackColor = true;
            this.checkBoxNuloCrip.CheckedChanged += new System.EventHandler(this.checkBoxNuloCrip_CheckedChanged);
            // 
            // checkBoxDes
            // 
            this.checkBoxDes.AutoSize = true;
            this.checkBoxDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDes.Location = new System.Drawing.Point(628, 164);
            this.checkBoxDes.Name = "checkBoxDes";
            this.checkBoxDes.Size = new System.Drawing.Size(65, 24);
            this.checkBoxDes.TabIndex = 21;
            this.checkBoxDes.Text = "DES";
            this.checkBoxDes.UseVisualStyleBackColor = true;
            this.checkBoxDes.CheckedChanged += new System.EventHandler(this.checkBoxDes_CheckedChanged);
            // 
            // checkBoxAes
            // 
            this.checkBoxAes.AutoSize = true;
            this.checkBoxAes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAes.Location = new System.Drawing.Point(628, 121);
            this.checkBoxAes.Name = "checkBoxAes";
            this.checkBoxAes.Size = new System.Drawing.Size(64, 24);
            this.checkBoxAes.TabIndex = 20;
            this.checkBoxAes.Text = "AES";
            this.checkBoxAes.UseVisualStyleBackColor = true;
            this.checkBoxAes.CheckedChanged += new System.EventHandler(this.checkBoxAes_CheckedChanged);
            // 
            // checkBoxNuloAut
            // 
            this.checkBoxNuloAut.AutoSize = true;
            this.checkBoxNuloAut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNuloAut.Location = new System.Drawing.Point(432, 207);
            this.checkBoxNuloAut.Name = "checkBoxNuloAut";
            this.checkBoxNuloAut.Size = new System.Drawing.Size(76, 24);
            this.checkBoxNuloAut.TabIndex = 19;
            this.checkBoxNuloAut.Text = "NULO";
            this.checkBoxNuloAut.UseVisualStyleBackColor = true;
            this.checkBoxNuloAut.CheckedChanged += new System.EventHandler(this.checkBoxNuloAut_CheckedChanged);
            // 
            // checkBoxMd5
            // 
            this.checkBoxMd5.AutoSize = true;
            this.checkBoxMd5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMd5.Location = new System.Drawing.Point(432, 164);
            this.checkBoxMd5.Name = "checkBoxMd5";
            this.checkBoxMd5.Size = new System.Drawing.Size(65, 24);
            this.checkBoxMd5.TabIndex = 18;
            this.checkBoxMd5.Text = "MD5";
            this.checkBoxMd5.UseVisualStyleBackColor = true;
            this.checkBoxMd5.CheckedChanged += new System.EventHandler(this.checkBoxMd5_CheckedChanged);
            // 
            // checkBoxSha1
            // 
            this.checkBoxSha1.AutoSize = true;
            this.checkBoxSha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSha1.Location = new System.Drawing.Point(432, 121);
            this.checkBoxSha1.Name = "checkBoxSha1";
            this.checkBoxSha1.Size = new System.Drawing.Size(75, 24);
            this.checkBoxSha1.TabIndex = 17;
            this.checkBoxSha1.Text = "SHA1";
            this.checkBoxSha1.UseVisualStyleBackColor = true;
            this.checkBoxSha1.CheckedChanged += new System.EventHandler(this.checkBoxSha1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(624, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 41);
            this.label8.TabIndex = 16;
            this.label8.Text = "ALGORÍTMO DE CRIPTOGRAFIA";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(428, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 41);
            this.label7.TabIndex = 15;
            this.label7.Text = "ALGORÍTMO DE AUTENTICAÇÃO";
            // 
            // txtBoxSenhaCrip
            // 
            this.txtBoxSenhaCrip.Location = new System.Drawing.Point(175, 186);
            this.txtBoxSenhaCrip.Name = "txtBoxSenhaCrip";
            this.txtBoxSenhaCrip.Size = new System.Drawing.Size(152, 20);
            this.txtBoxSenhaCrip.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 41);
            this.label6.TabIndex = 10;
            this.label6.Text = "SENHA DE CRIPTOGRAFIA";
            // 
            // txtBoxSenhaAut
            // 
            this.txtBoxSenhaAut.Location = new System.Drawing.Point(175, 121);
            this.txtBoxSenhaAut.Name = "txtBoxSenhaAut";
            this.txtBoxSenhaAut.Size = new System.Drawing.Size(152, 20);
            this.txtBoxSenhaAut.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 41);
            this.label5.TabIndex = 8;
            this.label5.Text = "SENHA DE AUTENTICAÇÃO";
            // 
            // txtBoxUsuarioSnmp
            // 
            this.txtBoxUsuarioSnmp.Location = new System.Drawing.Point(175, 57);
            this.txtBoxUsuarioSnmp.Name = "txtBoxUsuarioSnmp";
            this.txtBoxUsuarioSnmp.Size = new System.Drawing.Size(152, 20);
            this.txtBoxUsuarioSnmp.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArquivo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(970, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuArquivo
            // 
            this.menuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configSMTPToolStripMenuItem});
            this.menuArquivo.Name = "menuArquivo";
            this.menuArquivo.Size = new System.Drawing.Size(61, 20);
            this.menuArquivo.Text = "Arquivo";
            // 
            // configSMTPToolStripMenuItem
            // 
            this.configSMTPToolStripMenuItem.Name = "configSMTPToolStripMenuItem";
            this.configSMTPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configSMTPToolStripMenuItem.Text = "Config SMTP";
            this.configSMTPToolStripMenuItem.Click += new System.EventHandler(this.configSMTPToolStripMenuItem_Click);
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.Location = new System.Drawing.Point(792, 100);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(151, 23);
            this.btnEnviarEmail.TabIndex = 6;
            this.btnEnviarEmail.Text = "Enviar Email";
            this.btnEnviarEmail.UseVisualStyleBackColor = true;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Teste Impressoras MIB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetTotalPag;
        private System.Windows.Forms.Button btnTotalPagMono;
        public System.Windows.Forms.TextBox txtboxOid;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtBoxIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtBoxUsuarioSnmp;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtBoxSenhaAut;
        public System.Windows.Forms.TextBox txtBoxSenhaCrip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxNuloAut;
        private System.Windows.Forms.CheckBox checkBoxMd5;
        private System.Windows.Forms.CheckBox checkBoxSha1;
        private System.Windows.Forms.CheckBox checkBoxNuloCrip;
        private System.Windows.Forms.CheckBox checkBoxDes;
        private System.Windows.Forms.CheckBox checkBoxAes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuArquivo;
        private System.Windows.Forms.ToolStripMenuItem configSMTPToolStripMenuItem;
        private System.Windows.Forms.Button btnEnviarEmail;
    }
}

