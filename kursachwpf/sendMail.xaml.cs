using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace kursachwpf
{
    /// <summary>
    /// Логика взаимодействия для sendMail.xaml
    /// </summary>
    public partial class sendMail : Window
    {
        MainWindow mw;
        public sendMail(MainWindow mw)
        {
            InitializeComponent();
            this.mw = mw;
        }
        public sendMail()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            TextRange textRange = new TextRange(
                    rtbSendMail.Document.ContentStart,
                    rtbSendMail.Document.ContentEnd
            );
            string lore = textRange.Text;
            SmtpClient client = new SmtpClient();
            client.Credentials = new NetworkCredential("leagueoflegendswpf@mail.ru", "YPQvZkefiDN8Abt8vscF");
            client.Host = "smtp.mail.ru";
            client.Port = 25;
            client.EnableSsl = true;
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("leagueoflegendswpf@mail.ru");
            mail.To.Add("leagueoflegendswpf@mail.ru");
            mail.Subject = "Сообщение от пользователя Legends of Runeterra(wpf)";
            mail.IsBodyHtml = true;
            mail.Body = "<h2> Сообщение от пользователя! </h2><br><br>Его логин: " + mw.nameAuthedUser + "<br>Его почта: " + mw.emailAuthedUser + "<br>Его сообщение: " + lore;
            client.Send(mail);
            MessageBox.Show("Вы успешно отправили свое сообщение! ", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            mw.Show();
        }
    }
}
