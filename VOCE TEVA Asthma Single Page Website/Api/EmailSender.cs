using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using VOCE_TEVA_Asthma_Single_Page_Website.Models;

namespace VOCE_TEVA_Asthma_Single_Page_Website.Api
{
    public class EmailSender
    {
        internal void SendEmail(EmailModel model)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient client = new SmtpClient();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                int port = 25;
                if(int.TryParse(ConfigurationManager.AppSettings.Get("EmailPort"),out port))
                {
                    client.Port = port;
                }
                else
                {
                    throw new Exception("Email port must be an integer");
                }
                bool useDefaultCredentials = true;
                if(bool.TryParse(ConfigurationManager.AppSettings.Get("UseDefaultCredentials"),out useDefaultCredentials))
                {
                    client.UseDefaultCredentials = useDefaultCredentials;
                }
                else
                {
                    throw new Exception("UseDefaultCredentials muts be true or false");
                }
                client.Credentials = new NetworkCredential(ConfigurationManager.AppSettings.Get("EmailUser"), ConfigurationManager.AppSettings.Get("EmailPassword"));
                client.Host = ConfigurationManager.AppSettings.Get("EmailHost");
                mail.From = new MailAddress(model.From);
                string[] emailsToSend = model.To.Split(',');
                foreach(string emails in emailsToSend)
                {
                    mail.To.Add(new MailAddress(emails));
                }
                mail.Subject = model.Subject;
                mail.Body = model.Message;
                client.Send(mail);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}