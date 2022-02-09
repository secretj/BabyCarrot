using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace BabyCarrot.Tools
{
    public class EmailManager
    {
        private MailMessage _MailMessage;
        private SmtpClient _SmtpClient;

        public EmailManager(string host, int port,string id, string password)
        {
            _SmtpClient = new SmtpClient(host, port);
            _SmtpClient.Credentials = new NetworkCredential(id, password);
            
            _MailMessage = new MailMessage();
            _MailMessage.IsBodyHtml = true;
            _MailMessage.Priority = MailPriority.Normal;
           /* _MailMessage.Attachments.Add(new Attachment());
            파일첨부관련*/
        }

        public string From
        {
            get { return _MailMessage.From == null? String.Empty : _MailMessage.From.Address; }
            set { _MailMessage.From = new MailAddress(value); }
        }

        public MailAddressCollection To
        {
            get { return _MailMessage.To; }
        }
        public string Subject
        {
            get {  return _MailMessage.Subject; }   
            set { _MailMessage.Subject = value;}
        }

        public string Body
        {
            get { return _MailMessage.Body; }  
            set { _MailMessage.Body = value;}
        }
        
        public void Send()
        {
            _SmtpClient.Send(_MailMessage);
        }

        #region Static Methods
        public static void Send(string to, string subject, string contents)
        {
            string sender = "do_not_reply@test.com";
            Send(sender, to, subject, contents);
            /*컴퓨터가 하나 이상의 외부와 통신할 수 있는데 각각의 서비스는 하나의 포트넘버를 가진다.
            그래서 서비스를 구분할 수 있음
            특정 컴퓨터의 특정 서비스를 찾기 위해서는 특정 ip address와 서비스 port넘버가 필요하다.
            우리가 여기서 만들 메일전송서비스는 smtp라는 프로토콜을 찾아가야함 */
        }

        //보내는 사람을 매개변수로 받는 Send 메소드
        public static void Send(string from, string to, string subject, string contents, string cc, string bcc)
        {
            if (String.IsNullOrEmpty(from))
                throw new ArgumentNullException("Sender is empty.");
            if (String.IsNullOrEmpty(to))
                throw new ArgumentException("To is empty.");

            string sender = "do_not_reply@test.com";

            string smtpHost = "smtp.com";
            int smtpPort = 2525;

            string smtpId = "id";
            string smtpPwd = "password";

            MailMessage mailMsg = new MailMessage();
            mailMsg.From = new MailAddress(from);
            mailMsg.To.Add(to);

            if (!String.IsNullOrEmpty(cc))
                mailMsg.CC.Add(cc);
            if(!String.IsNullOrEmpty(bcc))
                mailMsg.Bcc.Add(bcc);

            mailMsg.Subject = subject;
            mailMsg.IsBodyHtml = true;
            mailMsg.Body = contents;
            mailMsg.Priority = MailPriority.Normal;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(smtpId, smtpPwd);
            smtpClient.Host = smtpHost;
            smtpClient.Port = smtpPort;
            smtpClient.Send(mailMsg);
        }

        public static void Send(string from, string to, string subject, string contents)
        {
            Send(from, to, subject, contents, null, null);
        }
    }
    #endregion
}
