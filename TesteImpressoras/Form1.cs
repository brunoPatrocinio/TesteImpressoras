using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Lextm.SharpSnmpLib.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnmpSharpNet;
using TimeoutException = System.TimeoutException;

namespace TesteImpressoras
{
    public partial class Form1 : Form
    {
        Impressora imp1;
        
        public int selecaoAut;
        public int selecaoCrip;
       
        ConfigSmtp cfSmtp;
        public Form1()
        {
            InitializeComponent();
            
        }

        public Form1( ConfigSmtp cfSmtp)
        {
            
            this.cfSmtp = cfSmtp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {         
            checkBoxSha1.Checked = true;
            checkBoxDes.Checked = true;
        }
        
        private void btnGetMibInfo_Click(object sender, EventArgs e)
        {           
            try
            {
                if (txtBoxIp.Text != string.Empty)
                {
                    imp1 = new Impressora();
                    Oid oid = new Oid(txtboxOid.Text); //substituir o oid de testes
                    imp1.getInformationByOid(oid, imp1.ip);
                }
                else
                {
                    MessageBox.Show("Campo vazio, preencha com o IP corretamente."
                                , "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(TimeoutException ex)
            {
                MessageBox.Show("Não foi possível obter as informações desejadas. Verifique se o Endereço de IP está correto.\n" 
                                + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            
        }

        private void btnGetMibInfoSnmpV3_Click(object sender, EventArgs e)
        { // "canon3010" "canonse1#", "canon20241#"  1.3.6.1.2.1.25.3.2.1.3.1
            try
            {
                if (txtBoxIp.Text != string.Empty)
                {
                    imp1 = new Impressora();
                    
                    Oid oid = new Oid(txtboxOid.Text); //substituir o oid de testes
                    imp1.getInformationByOidV3(oid, imp1.ip, txtBoxUsuarioSnmp.Text, txtBoxSenhaAut.Text, txtBoxSenhaCrip.Text, selecaoAut, selecaoCrip); //passar as info referente a usuario e autenticações Snmp V3
                }
                else
                {
                    MessageBox.Show("Campo vazio, preencha com o IP corretamente."
                                , "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(TimeoutException ex)
            {
                MessageBox.Show("Não foi possível obter as informações desejadas. Verifique se o Endereço de IP está correto.\n" 
                                + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtBoxIp_TextChanged(object sender, EventArgs e)
        {

        }

        //checkboxes Aut
        private void checkBoxSha1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSha1.Checked)
            {
                checkBoxMd5.Checked = false;
                checkBoxNuloAut.Checked = false;
                selecaoAut = 1;

            }
           
        }

        private void checkBoxMd5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMd5.Checked)
            {
                checkBoxSha1.Checked = false;
                checkBoxNuloAut.Checked = false;
                selecaoAut = 2;
            }
            
        }

        private void checkBoxNuloAut_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNuloAut.Checked)
            {
                checkBoxSha1.Checked = false;
                checkBoxMd5.Checked = false;
                selecaoAut = 3;
            }
        }

        //checkboxes Crip
        private void checkBoxAes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAes.Checked)
            {
                checkBoxDes.Checked = false;
                checkBoxNuloCrip.Checked = false;
                selecaoCrip = 1;
            }
        }

        private void checkBoxDes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDes.Checked)
            {
                checkBoxAes.Checked = false;
                checkBoxNuloCrip.Checked = false;
                selecaoCrip = 2;
            }
        }

        private void checkBoxNuloCrip_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxAes.Checked = false;
            checkBoxDes.Checked = false;
            selecaoCrip = 3;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sMTPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void configSMTPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigSmtp formSmtp = new ConfigSmtp();
            formSmtp.ShowDialog();
        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            int ativ;
            Oid oid = new Oid(txtboxOid.Text);
            ativ = 1;
            //if (cfSmtp.checkBoxSSL.Checked)
            //{
            //    ativ = 1;
            //}
            //else
            //{
            //    ativ = 0;
            //}
            string enviar = imp1.getInformationByOid(oid, txtBoxIp.Text).ToString();
            Smtp.enviarMail("brushevchenko@gmail.com", "brunobrushevchenko@hotmail.com", "Info. Impressora",enviar,
                            "587", "smtp.gmail.com", "brushevchenko@gmail.com", "vyqf xnnq sygd lndy", 1);

            //smtp.enviarMail(cfSmtp.txtBoxEmailFrom.Text, cfSmtp.txtBoxMailTo.Text, cfSmtp.txtBoxTituloEmail.Text, imp1.getInformationByOid(oid, txtBoxIp.Text),
            //                cfSmtp.txtBoxPorta.Text, cfSmtp.txtBoxSmtpclient.Text, cfSmtp.txtBoxUsuario.Text, cfSmtp.txtBoxSenha.Text, ativ);
        }

        private void btnVerificarConexao_Click(object sender, EventArgs e)
        {
            Impressora imp2 = new Impressora();
            
            string retorno = imp2.pingar(txtBoxIp.Text);
            if(retorno == "conectado")
            {
                lblStatus.Text = "CONECTADO";                
                lblStatus.BackColor = Color.Green;
                picBoxStatus.BackColor = Color.Green;
            }
            else
            {
                lblStatus.Text = "NÃO CONECTADO";
                lblStatus.BackColor = Color.Red;
                picBoxStatus.BackColor = Color.Red;
            }
        }
    }
}
