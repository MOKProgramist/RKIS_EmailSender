using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKIS_EmailSender.UsersСlasses
{
    public class StringPair
    {
        private string _emailAdress;
        private string _name;

        public StringPair(string emailAdress, string name)
        {
            EmailAdress = String.IsNullOrWhiteSpace(emailAdress) ? throw new Exception("Нельзя вставлять пробелы или пустое значение!") : emailAdress;
            Name = String.IsNullOrWhiteSpace(name) ? throw new Exception("Нельзя вставлять пробелы или пустое значение!") : name;
        }

        public string EmailAdress { 
            get { return _emailAdress; } 
            set
            {
                _emailAdress = String.IsNullOrWhiteSpace(value) ? throw new ArgumentNullException(nameof(_emailAdress)) : value;
            }
        }
        public string Name {
            get { return _name; }
            set
            {
                _name = String.IsNullOrWhiteSpace(value) ? throw new ArgumentNullException(nameof(_name)) : value;
            }
        }
    }
}
