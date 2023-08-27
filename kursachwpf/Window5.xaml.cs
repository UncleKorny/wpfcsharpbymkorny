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

namespace kursachwpf
{
    /// <summary>
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        Window4 wn4;
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "data source=C:/databases/champions1.accdb";
        public Window5(Window4 wn4)
        {
            InitializeComponent();
            this.wn4 = wn4;
        }
        public Window5()
        {
            InitializeComponent();
        }

        private void lbwlogin_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            wn4.Show();
            this.Close();
        }


        private void btnreg_Click(object sender, RoutedEventArgs e)
        {
            //регистрация аккаунта пользователя в бд 
            if (tblogin.Text != "" && tbpass.Text != "" && tbpass2.Text != "" && tbemail.Text != "")
            {
                if (tbpass.Text == tbpass2.Text)
                {
                    string name = tblogin.Text;
                    string pass = tbpass.Text;
                    string email = tbemail.Text;
                    OleDbConnection connection = new OleDbConnection(connectString);
                    connection.Open();
                    string sql = "INSERT INTO tabacc([login],[password],[email],[rights]) VALUES ('" + name + "', '" + pass + "','"+email+"','0')";
                    OleDbCommand command = new OleDbCommand(sql, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Вы успешно зарегистрировались!", "Успех!", MessageBoxButton.OK, MessageBoxImage.Information);
                    wn4.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void lbwrecover_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}
