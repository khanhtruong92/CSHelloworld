using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSHelloworld
{
    internal class Mail
    {
        public string sender { get; set; }
        public string recipients { get; set; }
        public string subject { get; set; }
        public string body { get; set; }

        public Mail(string sender)
        {
            this.sender = sender;
        }

    }

    class SendGrid : Mail
    {
        public SendGrid(string sender) : base(sender) { }
        public void SendMail()
        {
            Console.WriteLine("SendGrid successfully sent to " + recipients);
            Console.WriteLine("Sender: " + sender);
            Console.WriteLine("Subject: " + subject);
            Console.WriteLine("Content: " + body);
        }

    }

    class MailChimp : Mail
    {
        public MailChimp(string sender) : base(sender) { }
        public void SendMail()
        {
            Console.WriteLine("MailChimp successfully sent to " + recipients);
            Console.WriteLine("Sender: " + sender);
            Console.WriteLine("Subject: " + subject);
            Console.WriteLine("Content: " + body);
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            string sender = "youremail@yourdomain.com";
            string recipients = "emailID@domain.com";
            string subject = "Just a Test";
            string body = "Hi Name, How are you?";

            SendGrid sendGridMail = new SendGrid(sender);
            sendGridMail.recipients = recipients;
            sendGridMail.subject = subject;
            sendGridMail.body = body;
            sendGridMail.SendMail();

            Console.WriteLine("\n");

            MailChimp mailChimp = new MailChimp(sender);
            mailChimp.recipients = recipients;
            mailChimp.subject = subject;
            mailChimp.body = body;
            mailChimp.SendMail();

        }
    }
}
