using Microsoft.Win32;
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
using System.IO;

namespace kursachwpf
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        Window1 wn1;
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "data source=C:/databases/champions1.accdb";
        string pathdict = @"C:\Users\themk\source\repos\kursachwpf\kursachwpf\dictionary.txt";
        public Window2(Window1 wn1)
        {
            InitializeComponent();
            this.wn1 = wn1;
        }
        public Window2()
        {
            InitializeComponent();
        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        public string uploadFileName;
        public string uploadFileNameWithoutExtension;
        public string uploadPath;
        public string uploadFilePathName;
        private void btnaddimage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Изображения (*.jpg)|*.jpg";
                if (opf.ShowDialog() == true)
                {
                    uploadPath = @"C:\Users\themk\source\repos\kursachwpf\kursachwpf\images\" + opf.SafeFileName;
                    uploadFilePathName = opf.FileName;
                    uploadFileName = System.IO.Path.GetFileName(opf.FileName);
                    uploadFileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(opf.FileName);
                    labl1.Content = uploadFileName;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = tbname.Text;
            if (!File.ReadAllLines(@"C:\Users\themk\source\repos\kursachwpf\kursachwpf\champik.txt").Contains(name))
            {
                TextRange textRange = new TextRange(
                    rtb1.Document.ContentStart,
                    rtb1.Document.ContentEnd
                );
                string lore = textRange.Text;
                string championclass;
                if (cb1.SelectedItem != null)
                {
                    championclass = cb1.SelectedItem.ToString();
                    OleDbConnection connection = new OleDbConnection(connectString);
                    connection.Open();
                    string query = "INSERT INTO tabl1 (namee, story, class) VALUES ('" + name + "','" + lore + "','"+championclass+"')";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Выберите класс чемпиона");
                }
                string path = @"C:\Users\themk\source\repos\kursachwpf\kursachwpf\champik.txt";
                StreamWriter sw = new StreamWriter(path,true);
                sw.WriteLine(name);
                sw.Close();
                wn1.lb1.Items.Clear();
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
                    wn1.lb1.Items.Add(s);
                }
                wn1.lb1.SelectedIndex = -1;
                using (StreamWriter swr = new StreamWriter(pathdict,true))
                {
                    swr.WriteLine(name + "," + uploadFileNameWithoutExtension); 
                }
                System.IO.File.Copy(uploadFilePathName, uploadPath);
                
                MessageBox.Show("Добавлено");
            }
            else
            {
                MessageBox.Show("Такой чемпион уже есть");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> list = new List<string>();
            for(int i = 1; i < wn1.list2.Count; i++)
            {
                list.Add(wn1.list2[i]);
            }
            cb1.ItemsSource = list;
        }
    }
}
