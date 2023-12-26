using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RKIS_EmailSender.UsersСlasses;

namespace RKIS_EmailSender
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            textBoxEmail.Text = "task_code_development@list.ru";
            textBoxName.Text = "Андрей Романов";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxSubject.Text) || string.IsNullOrEmpty(textBoxBody.Text) ) {

                MessageBox.Show("Заполните все поля");

                return;

            }

            string smtp = "smtp.mail.ru";

            StringPair fromInfo = new StringPair("romanov201573@mail.ru", "Андрей Романов");


            string passpord = "пароль)";

            StringPair toInfo = new StringPair(textBoxEmail.Text, textBoxName.Text);

            string subject = textBoxSubject.Text;

            string body = $"{DateTime.Now}\n" + 
                $"{Dns.GetHostName()} \n" + 
                $"{Dns.GetHostAddresses(Dns.GetHostName())} \n" +
                $"{textBoxBody.Text}";

            InfoEmailSending info = new InfoEmailSending(smtp, fromInfo, passpord, toInfo, subject, body);

            SendingEmail sendingEmail = new SendingEmail(info);

            sendingEmail.Send();

            MessageBox.Show("Письмо отправлено");

            foreach(TextBox textBox in Controls.OfType<TextBox>())
            {
                textBox.Text = "";
            }
        }
    }
}
