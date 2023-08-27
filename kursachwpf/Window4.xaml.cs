using System;
using System.Collections.Generic;
using System.Data.OleDb;
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

namespace kursachwpf
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "data source=C:/databases/champions1.accdb";
        Window1 wn1;
        public Window4(Window1 wn1)
        {
            InitializeComponent();
            this.wn1 = wn1;
        }
        public Window4()
        {
            InitializeComponent();
        }

        private void lbregister_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window5 wn5 = new Window5(this);
            wn5.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connectString);
            connection.Open();
            
            string query = "select login, password, rights, email from tabacc";
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader reader = command.ExecuteReader();
            List<string> ltb = new List<string>();
            while (reader.Read())
            {
                if(tblogin.Text != "" || tblogin.Text != "")
                {
                    if (tblogin.Text == reader.GetString(0) && tbpass.Password.ToString() == reader.GetString(1))
                    {
                        if (reader.GetString(2) == "1")
                        {
                            MessageBox.Show("Вы вошли в систему как Администратор!");
                            wn1.btnauth.Visibility = Visibility.Hidden;
                            wn1.btnadd.Visibility = Visibility.Visible;
                            wn1.btndelete.Visibility = Visibility.Visible;
                            wn1.btnedit.Visibility = Visibility.Visible;
                            wn1.mw.isAuthed = true;
                            wn1.mw.nameAuthedUser = tblogin.Text;
                            wn1.mw.emailAuthedUser = reader.GetString(3);
                            wn1.mw.rights = reader.GetString(2);                        
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Вы вошли в систему");
                            wn1.btnauth.Visibility = Visibility.Hidden;
                            wn1.lblname.Visibility = Visibility.Visible;
                            wn1.lblname.Content = tblogin.Text;
                            wn1.mw.isAuthed = true;
                            wn1.mw.nameAuthedUser = tblogin.Text;
                            wn1.mw.emailAuthedUser = reader.GetString(3);
                            wn1.mw.rights = reader.GetString(2);
                            this.Close();
                        }

                    }
                    else if (tblogin.Text == reader.GetString(0) && tbpass.Password.ToString() != reader.GetString(1))
                    {
                        MessageBox.Show("Неверный пароль!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    ltb.Add(reader.GetString(0));
                }
                else
                {
                    MessageBox.Show("Введите логин или пароль!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            if (!ltb.Contains(tblogin.Text)) {
                MessageBox.Show("Такой пользователь не существует");
            }
            connection.Close();
        }

        private void lbwrecover_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window6 wn6 = new Window6(this);
            wn6.Show();
            this.Hide();
        }
    }
}