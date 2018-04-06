using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net.Mime;

namespace Student.Common.Logic.FileUtils
{
    public static class MailSend
    {
        private const string Address = "danieltristan1991@gmail.com";

        public static void Send(string text)
        {
            MailMessage mail;
            SmtpClient SmtpServer = new SmtpClient();
            try
            {
               
                SmtpServer.Credentials = new System.Net.NetworkCredential
                            ("mindundi1490@gmail.com", "Mindundi1490+");
                SmtpServer.Port = 587;
                SmtpServer.Host = "smtp.gmail.com";
                SmtpServer.EnableSsl = true;
                mail = new MailMessage("mindundi1490@gmail.com",Address);
                mail.Subject = "Excepcion no controlada";
                mail.Body = text;
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            finally
            {
                SmtpServer.Dispose();
            }
        }
    }
}
