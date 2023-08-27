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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kursachwpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool tutorialAccept = false;
        public int openOnce = 0;
        public bool isAuthed = false;
        public string nameAuthedUser;
        public string emailAuthedUser;
        public string passwordAuthedUser;
        public string rights;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Window1 wn1 = new Window1(this);
            
            wn1.Show();
            if (isAuthed)
            {
                if (rights == "1")
                {
                    wn1.btnauth.Visibility = Visibility.Hidden;
                    wn1.btnadd.Visibility = Visibility.Visible;
                    wn1.btndelete.Visibility = Visibility.Visible;
                    wn1.btnedit.Visibility = Visibility.Visible;
                }
                else
                {
                    wn1.btnauth.Visibility = Visibility.Hidden;
                    wn1.lblname.Visibility = Visibility.Visible;
                    wn1.lblname.Content = nameAuthedUser;
                }
            }
            this.Hide();
        }


        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            about mw = new about(this);
            mw.Show();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void btntutor_Click(object sender, RoutedEventArgs e)
        {
            tutorial tut = new tutorial(this);
            tut.Show();
            this.Hide();
        }

        private void btnSendMail_Click(object sender, RoutedEventArgs e)
        {
            if (isAuthed)
            {
                sendMail sm = new sendMail(this);
                this.Hide();
                sm.Show();
            }
            else
            {
                MessageBox.Show("Вы не авторизованы","Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
