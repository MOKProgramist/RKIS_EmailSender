using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RKIS_EmailSender.UsersСlasses
{
    internal class InfoEmailSending
    {
        public InfoEmailSending(string smtpClientAdress, StringPair emailAdressFrom, string emailPassport, StringPair emailAdressTo, string subject, string body)
        {
            SmtpClientAdress = String.IsNullOrWhiteSpace(smtpClientAdress) ? throw new Exception("Нельзя вставлять пробелы или пустое значение!") : smtpClientAdress;
            EmailAdressFrom = emailAdressFrom ?? throw new ArgumentNullException(nameof(emailAdressFrom));

            EmailPassport = emailPassport ?? throw new ArgumentNullException( nameof(emailPassport));

            EmailAdressTo = emailAdressTo ?? throw new ArgumentNullException($"{nameof(emailAdressTo)}");

            Subject = subject ?? throw new ArgumentNullException(nameof(subject));

            Body = body ?? throw new ArgumentNullException(nameof(subject));
        }

        public string SmtpClientAdress { get; set; }
        public StringPair EmailAdressFrom { get; set; }
        public string EmailPassport { get; set; }
        public StringPair EmailAdressTo {  get; set; }
        public string Subject { get; set; }
        public string Body {  get; set; }
    }




}
