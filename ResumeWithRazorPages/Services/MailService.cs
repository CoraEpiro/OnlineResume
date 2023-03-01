using ResumeWithRazorPages.Model;
using System.Net;
using System.Net.Mail;

namespace ResumeWithRazorPages.Services
{
    public class MailService
    {
        public void Send(Mail mail)
        {
            Send(mail, GetAdress(), GetPassword());
        }

        private void Send(Mail mail, string fromAddress, string fromPassword)
        {
            SmtpClient smtpClient = new SmtpClient
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                EnableSsl = true,
                Host = "smtp.gmail.com",
                Port = 25,
                Credentials = new NetworkCredential(fromAddress, fromPassword)
            };

            string subject = $"Resume Form: Name: {mail.Name} || Sender: {mail.Email}";
            try
            { 
                smtpClient.Send(fromAddress, ToAdress(), subject, mail.Message);
            }
            catch (SmtpException e)
            {
                Console.WriteLine(e);
            }
        }
        private string ToAdress()
        {
            return "aguliyev45@gmail.com";
        }
        private string GetPassword()
        {
            return "szoeearbulroeolw";
        }
        private string GetAdress()
        {
            return "forsendingemailsfromresumeform@gmail.com";
        }
    }
}
