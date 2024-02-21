using Common.Domenske_Klase;
using Common.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Specifične_SO
{
    public class SOSendEmail : SystemOperationBase
    {
        public bool Result { get; private set; }
        string toEmail;
        string newPassword;
        List<Putnik> listaPutnika = new List<Putnik>();
        List<User> listaAdministratora = new List<User>();
        User u = new User();

        bool postoji = false;
        public SOSendEmail(string toEmail, string newPassword)
        {
            this.toEmail = toEmail;
            this.newPassword = newPassword;
        }
        protected override void Execute()
        {
           // listaPutnika = repository.GetAll(new Putnik()).OfType<Putnik>().ToList();
            listaAdministratora = repository.GetAll(new User()).OfType<User>().ToList();

            foreach (User user in listaAdministratora)
            {
                if (user.Email == this.toEmail)
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient smtpServer = new SmtpClient("smtp-mail.outlook.com");

                    mail.From = new MailAddress("putnikprogramer@hotmail.com");
                    mail.To.Add(toEmail);
                    mail.Subject = "Reset lozinke";
                    mail.Body = "Vaša nova lozinka je: " + newPassword;

                    smtpServer.Port = 587;
                    smtpServer.Credentials = new System.Net.NetworkCredential("putnikprogramer@hotmail.com", "diplomski2023");
                    smtpServer.EnableSsl = true;

                    smtpServer.Send(mail);
                    postoji = true;
                    u = user;
                    u.Password = newPassword;
                    repository.Update(u);
                    break;
                }
            }

            Result = postoji;
        }
    }
}
