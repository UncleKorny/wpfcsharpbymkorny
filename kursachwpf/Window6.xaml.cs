using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Data.OleDb;
using System.Net.Mail;
using System.Net;

namespace kursachwpf
{
    /// <summary>
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        Window4 wn4;
        public string emailForRecover;
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "data source=C:/databases/champions1.accdb";
        public Window6(Window4 wn4)
        {
            InitializeComponent();
            this.wn4 = wn4;
        }
        public Window6()
        {
            InitializeComponent();
        }

        private void btnsend_Click(object sender, RoutedEventArgs e)
        {
            string email = tbemail.Text;
            var connection = new OleDbConnection(connectString);
            OleDbCommand myOleDbCommand = connection.CreateCommand();
            myOleDbCommand.CommandText = "select [email] from [tabacc] where [email] = '" + email + "'";
            connection.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(myOleDbCommand);
            emailForRecover = (string)da.SelectCommand.ExecuteScalar();
            connection.Close();
            if(email == emailForRecover)
            {
                MessageBox.Show("Такой аккаунт действительно существует!");
                tbemail.Visibility = Visibility.Hidden;
                lblemail.Visibility = Visibility.Hidden;
                btnsend.Visibility = Visibility.Hidden;
                tbnewpass.Visibility = Visibility.Visible;
                lblnewpass.Visibility = Visibility.Visible;
                btnsetnewpass.Visibility = Visibility.Visible;
            }
        }

        private void btnsetnewpass_Click(object sender, RoutedEventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connectString);
            connection.Open();
            string query = "update [tabacc] set [password] = '" + tbnewpass.Text + "' where [email] = '" + emailForRecover + "'";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();

            var connection2 = new OleDbConnection(connectString);
            OleDbCommand myOleDbCommand = connection2.CreateCommand();
            myOleDbCommand.CommandText = "select [login] from [tabacc] where [email] = '" + emailForRecover + "'";
            connection2.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(myOleDbCommand);
            string nickname = (string)da.SelectCommand.ExecuteScalar();
            connection2.Close();


            //отправить сообщение на почту
            SmtpClient client = new SmtpClient();
            client.Credentials = new NetworkCredential("leagueoflegendswpf@mail.ru", "YPQvZkefiDN8Abt8vscF");
            client.Host = "smtp.mail.ru";
            client.Port = 25;
            client.EnableSsl = true;
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("leagueoflegendswpf@mail.ru");
            mail.To.Add(emailForRecover);
            mail.Subject = "Изменение пароля";
            mail.IsBodyHtml = true;
            mail.Body = "<h2> Вы изменили свой пароль! </h2><br><br>Ваш логин: " + nickname + "<br><br>Ваш новый пароль: " + tbnewpass.Text;
            client.Send(mail);
            MessageBox.Show("Вы успешно изменили пароль! Вся информация отправлена на почту! Если письмо не пришло, проверьте папку 'Спам'!");
            this.Close();
            wn4.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            wn4.Show();
        }
    }
}
