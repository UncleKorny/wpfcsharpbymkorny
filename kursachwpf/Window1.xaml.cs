using System;
using System.Collections.Generic;
using System.IO;
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
using System.Data;

namespace kursachwpf
{
    public partial class Window1 : Window
    {
        public MainWindow mw;
        
        public bool isAuthed = false;
        public string nameAuthedUser;
        public string emailAuthedUser;
        public string passwordAuthedUser;
        
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "data source=C:/databases/champions1.accdb";
        
        string pathdict = @"C:\Users\themk\source\repos\kursachwpf\kursachwpf\dictionary.txt";
        
        public Dictionary<string, string> dict = new Dictionary<string, string>();
        
        public List<string> list2 = new List<string>()
            {
                "",
                "Убийца",
                "Танк",
                "Маг",
                "Воин",
                "Стрелок",
                "Поддержка"
            };
        public Window1(MainWindow mw)
        {
            InitializeComponent();
            this.mw = mw; 
        }
        public Window1()
        {
            InitializeComponent();
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            mw.Show();
        }
        public void fillListBox()
        {
            lb1.Items.Clear();
            string path = @"C:\Users\themk\source\repos\kursachwpf\kursachwpf\champik.txt";
            List<string> list = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
            list.Sort();
            foreach (string s in list)
            {
                lb1.Items.Add(s);
            }
            lb1.SelectedIndex = 0;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btnauth.Visibility = Visibility.Visible;
            fillListBox();
            
            cb1.ItemsSource = list2;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string fsss = textBox1.Text.ToLower();
            List<string> list = new List<string>();
            foreach (string s in lb1.Items)
            {
                list.Add(s.ToLower());
            }
            for (int i = 0; i < lb1.Items.Count; i++)
            {
                if (list[i].ToString().Contains(fsss))
                {
                    lb1.SelectedIndex = i;
                    lb1.ScrollIntoView(lb1.SelectedItem);
                    break;
                }
            }
        }


        private void lb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lb1.SelectedItem != null)
            {
                string st = lb1.SelectedItem.ToString();
                    
                var connection = new OleDbConnection(connectString);
                OleDbCommand myOleDbCommand = connection.CreateCommand();
                myOleDbCommand.CommandText = "select [story] from [tabl1] where [namee] = '" + st + "'";
                connection.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(myOleDbCommand);
                textBlock1.Text = (string)da.SelectCommand.ExecuteScalar();
                connection.Close();
                
                string path;
                using (StreamReader sr = new StreamReader(pathdict))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] s = line.Split(',');
                        if (s[0] == st)
                        {
                            path = @"C:\Users\themk\source\repos\kursachwpf\kursachwpf\images\" + s[1] + ".jpg";
                            BitmapImage image = new BitmapImage();
                            image.BeginInit();
                            image.CacheOption = BitmapCacheOption.OnLoad;
                            image.UriSource = new Uri(path);
                            image.EndInit();
                            image1.Source = image;
                        }
                    }
                }
            }
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            Window2 wn2 = new Window2(this);
            wn2.Show();
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            Window3 wn3 = new Window3(this);
            wn3.Show();
        }

        private void btnauth_Click(object sender, RoutedEventArgs e)
        {
            Window4 wn4 = new Window4(this);
            wn4.Show();
        }

        private void cb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cb1.SelectedItem.ToString() != "")
            {
                string className = cb1.SelectedItem.ToString();
                var connection = new OleDbConnection(connectString);
                OleDbCommand myOleDbCommand = connection.CreateCommand();
                myOleDbCommand.CommandText = "select [namee] from [tabl1] where [class] = '" + className + "'";
                connection.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(myOleDbCommand);
                lb1.Items.Clear();
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    lb1.Items.Add(row[0].ToString());
                }
                connection.Close();
                lb1.SelectedIndex = 0;
            }
            else
            {
                fillListBox();
            }
        }

        private void btnedit_Click(object sender, RoutedEventArgs e)
        {
            var messageBox = MessageBox.Show("Перед продолжением прочитайте туториал на главном окне приложения!", "Предупреждение", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            if (messageBox == MessageBoxResult.OK)
            {
                if(mw.tutorialAccept == true)
                {
                    editChampions ec = new editChampions(this);
                    ec.Show();
                    ec.showInfo();
                }
            }
            
        }
    }
}