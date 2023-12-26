using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using RKIS_EmailSender.UsersСlasses;

namespace RKIS_EmailSender.UsersСlasses
{
    public abstract class InfoEmail
    {
        private string _smtpClientAdress;
        private StringPair _emailAdressFrom;
        private string _emailPasspord;
        private StringPair _emailAdressTo;
        private string _subject;
        private string _body;
        private int _port;

        public string SmtpClientAdress
        {
            get { return _smtpClientAdress;}
            set { _smtpClientAdress = String.IsNullOrWhiteSpace(value) ? throw new ArgumentNullException(nameof(_smtpClientAdress)) : value; }
        }

        public StringPair EmailAdressFrom
        {
            get { return _emailAdressFrom; }
            set { _emailAdressFrom = value ?? throw new ArgumentNullException(nameof(_emailAdressFrom)); }
        }

        public string EmailPassword
        {
            get { return _emailPasspord; }
            set { _emailPasspord = String.IsNullOrWhiteSpace(value) ? throw new ArgumentNullException(nameof(_emailAdressFrom)) : value; }
        }

        public StringPair EmailAdressTo
        {
            get { return _emailAdressTo; }
            set { _emailAdressTo = value ?? throw new ArgumentNullException(nameof(_emailAdressTo)); }
        }


        public string Subject
        {
            get { return _subject; }
            set { _subject = String.IsNullOrWhiteSpace(value) ? throw new ArgumentNullException(nameof(_subject)) : value; }
        }

        public string Body
        {
            get { return _body; }
            set { _body = String.IsNullOrWhiteSpace(value) ? throw new ArgumentNullException(nameof(_body)) : value; }
        }


        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }

        protected InfoEmail(StringPair emailAdressTo, string subject, string body)
        {
            EmailAdressTo = emailAdressTo;
            Subject = subject;
            Body = body;
        }
    }
}
