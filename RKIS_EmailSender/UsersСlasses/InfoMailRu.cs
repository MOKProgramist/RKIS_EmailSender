using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKIS_EmailSender.UsersСlasses
{
    public class InfoMailRu : InfoEmail
    {
        public InfoMailRu(StringPair emailAdressTo, string subject, string body) : base(emailAdressTo, subject, body)
        {
            SmtpClientAdress = "smtp.mail.ru";

            EmailAdressFrom = new StringPair("romanov201573@mail.ru", "Романов Андрей Романович");

            EmailPassword = "dtyWzw9fhwsmERNdSnvf";

            Port = -1;
        }
    }
}
