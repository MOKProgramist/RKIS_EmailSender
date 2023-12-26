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
        public void initSystemMailService()
        {
            comboBoxService.Items.Add("Gmail");
            comboBoxService.Items.Add("Mail");
            comboBoxService.SelectedIndex = 1;
        }
        public MainForm()
        {
            InitializeComponent();
            this.initSystemMailService();
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

        private bool IsNullOrWhiteSpaceTextBox()
        {
            if (string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxSubject.Text) || string.IsNullOrEmpty(textBoxBody.Text))
            {

                MessageBox.Show("Заполните все поля");

                return true;
            }

            return false;
        }

        private void TextBoxIsCleaning()
        {
            DialogResult result = MessageBox.Show("Очистить поле ввода?", "Сообщение", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                foreach (TextBox textBox in Controls.OfType<TextBox>())
                {
                    textBox.Text = "";
                }
            }
        }

        private InfoEmail SetInfoEmail(EmailsTypes emailType) {
            StringPair toInfo = new StringPair(textBoxEmail.Text, textBoxName.Text);

            string subject = textBoxSubject.Text;

            string body = $"{DateTime.Now}\n" +
                $"{Dns.GetHostName()} \n" +
                $"{Dns.GetHostAddresses(Dns.GetHostName())} \n" +
                $"{textBoxBody.Text}";

            if (emailType == EmailsTypes.MailRu)
            {
                return new InfoMailRu(toInfo, subject, body);    
            }

            return new InfoGMail(toInfo, subject, body);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if(IsNullOrWhiteSpaceTextBox()) { return; };

            try
            {
                SendingEmail sendingEmail = new SendingEmail(
                    SetInfoEmail((EmailsTypes) comboBoxService.SelectedIndex)
                    );
                sendingEmail.Send();

                MessageBox.Show("Письмо отправлено");

                TextBoxIsCleaning();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return;
            }

        }
    }
}
