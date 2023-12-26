using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKIS_EmailSender.UsersСlasses
{
    internal class InfoGMail: InfoEmail
    {
        public InfoGMail(StringPair emailAdressTo, string subject, string body): base(emailAdressTo, subject, body) {
            SmtpClientAdress = "smtp.gmail.com";

            EmailAdressFrom = new StringPair("is24romanovar@artcollege.ru", "Романов Андрей Романович");

            EmailPassword = "fajb jtil fnuz uopw";

            Port = 587;
        }
    }
}
