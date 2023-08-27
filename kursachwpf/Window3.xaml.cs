using System;
using System.Collections.Generic;
using System.Data.OleDb;
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

namespace kursachwpf
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "data source=C:/databases/champions1.accdb";
        string pathdict = @"C:\Users\themk\source\repos\kursachwpf\kursachwpf\dictionary.txt";
        Window1 wn1;
        public Window3(Window1 wn1)
        {
            InitializeComponent();
            this.wn1 = wn1;
        }
        public Window3()
        {
            InitializeComponent();
        }
        public void deleteImage(string path)
        {
            File.Delete(path);
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            if(cb1.SelectedItem == null)
            {
                MessageBox.Show("Ошибка! Выберите чемпиона для удаления!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                string path2;
                string selected = cb1.SelectedItem.ToString();
                wn1.lb1.SelectedIndex = 0;
                List<string> listdict = new List<string>();
                using (StreamReader sr = new StreamReader(pathdict))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] s = line.Split(',');
                        listdict.Add(s[0]+","+s[1]);
                        if (s[0] == selected)
                        {
                            path2 = @"C:\Users\themk\source\repos\kursachwpf\kursachwpf\images\" + s[1] + ".jpg";
                            File.Delete(path2);
                            listdict.Remove(s[0] + "," + s[1]);
                        }
                    }
                }
                using (StreamWriter swr = new StreamWriter(pathdict,false))
                {
                    foreach (string s in listdict)
                    {
                        swr.WriteLine(s);
                    }
                }
                string path = @"C:\Users\themk\source\repos\kursachwpf\kursachwpf\champik.txt";
                wn1.lb1.Items.Clear();
                List<string> lines = File.ReadAllLines(path).ToList();
                lines.Remove(selected);
                File.WriteAllLines(path, lines);
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
                cb1.Items.Clear();
                foreach (string s in list)
                {
                    wn1.lb1.Items.Add(s);
                    cb1.Items.Add(s);
                }
                wn1.lb1.SelectedIndex = 0;
                OleDbConnection connection = new OleDbConnection(connectString);
                connection.Open();
                string query = "DELETE FROM [tabl1] where [namee] = '" + selected + "'";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Чемпион удалён успешно!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string path = @"C:\Users\themk\source\repos\kursachwpf\kursachwpf\champik.txt";
            StreamReader sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                cb1.Items.Add(line);
            }
            sr.Close();
        }
    }
}
