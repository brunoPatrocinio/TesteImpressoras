using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.CodeDom;
using System.Net;
using System.Windows.Forms;

namespace TesteImpressoras
{
    public static class Smtp
    {
        
        //metodos
        public static void enviarMail(string mailFrom, string mailTo, string mailTitulo, string mailCorpo, string porta, 
                                 string smtpClient, string usuario, string senha, int temSSLouNao)
        {
            try
            {
                SmtpClient smtpClient1 = new SmtpClient(smtpClient);
                MailMessage mail = new MailMessage();

                smtpClient1.Port = Int32.Parse(porta);
                smtpClient1.Credentials = new NetworkCredential(usuario, senha);

                if (temSSLouNao == 1)
                {
                    smtpClient1.EnableSsl = true;
                }
                else
                {
                    smtpClient1.EnableSsl = false;
                }

                //configura o email a ser enviado
                mail.From = new MailAddress(mailFrom);
                mail.To.Add(mailTo);
                mail.Subject = mailTitulo;
                mail.Body = mailCorpo;

                //envia
                smtpClient1.Send(mail);
            }
            catch (SmtpFailedRecipientException ex)
            {
                MessageBox.Show("Falha ao enviar. O destinatário não pôde ser alcançado" + ex, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(SmtpException ex)
            {
                MessageBox.Show("Falha ao enviar e-mail: Problema com o servidor SMTP." + ex, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            catch(Exception ex)
            {
                MessageBox.Show("Erro desconhecido ao enviar e-mail." + ex, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                       
        }
    }
}
