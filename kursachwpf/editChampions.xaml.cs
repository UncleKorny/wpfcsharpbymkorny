using Microsoft.Win32;
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
    /// Логика взаимодействия для editChampions.xaml
    /// </summary>
    public partial class editChampions : Window
    {
        Window1 mw1;
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "data source=C:/databases/champions1.accdb";
        string pathdict = @"C:\Users\themk\source\repos\kursachwpf\kursachwpf\dictionary.txt";
        string champions = @"C:\Users\themk\source\repos\kursachwpf\kursachwpf\champik.txt";
        private string nameSelectedChampion;
        private string uploadFileNameWithoutExtension;
        private string uploadPath;
        private string uploadFilePathName;
        public editChampions(Window1 mw)
        {
            InitializeComponent();
            this.mw1 = mw;
            
        }
        public editChampions()
        {
            InitializeComponent();
        }
        public void showInfo()
        {
            if (mw1.lb1.SelectedItem != null)
            {
                nameSelectedChampion = mw1.lb1.SelectedItem.ToString();
                tbName.Text = nameSelectedChampion;
            }
        }
        public void deleteImageFromDirectory()
        {
            string path2;
            List<string> listdict = new List<string>();
            using (StreamReader sr = new StreamReader(pathdict))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] s = line.Split(',');
                    listdict.Add(s[0] + "," + s[1]);
                    if (s[0] == nameSelectedChampion)
                    {
                        path2 = @"C:\Users\themk\source\repos\kursachwpf\kursachwpf\images\" + s[1] + ".jpg";
                        File.Delete(path2);
                        listdict.Remove(s[0] + "," + s[1]);
                    }
                }
            }
            using (StreamWriter swr = new StreamWriter(pathdict, false))
            {
                foreach (string s in listdict)
                {
                    swr.WriteLine(s);
                }
            }
        }
        
        public void copyImageToDirectory()
        {
            try
            {
                using (StreamWriter swr = new StreamWriter(pathdict, true))
                {
                    swr.WriteLine(tbName.Text + "," + uploadFileNameWithoutExtension);
                }
                System.IO.File.Copy(uploadFilePathName, uploadPath);
            }
            catch(Exception ex)
            {
                
            }
        }
        public void editClassChampion()
        {
            OleDbConnection connection = new OleDbConnection(connectString);
            connection.Open();
            string query = "update [tabl1] set [class] = '" + cbClass.SelectedItem.ToString() + "' where [namee] = '" + nameSelectedChampion + "'";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void editStoryChampion()
        {
            try
            {
                TextRange textRange = new TextRange(
                        rtbHistory.Document.ContentStart,
                        rtbHistory.Document.ContentEnd
                );
                var lore = textRange.Text;
                OleDbConnection connection = new OleDbConnection(connectString);
                connection.Open();
                string query = "update [tabl1] set [story] = '"+lore+"' where [namee] =  '" + nameSelectedChampion + "'";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }
        public void editNameChampion()
        {
            OleDbConnection connection = new OleDbConnection(connectString);
            connection.Open();
            string query = "update [tabl1] set [namee] = '" + tbName.Text + "' where [namee] = '" + nameSelectedChampion + "'";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void editChampikTXT()
        {
            mw1.lb1.Items.Clear();
            List<string> lines = File.ReadAllLines(champions).ToList();
            lines.Remove(nameSelectedChampion);
            lines.Add(tbName.Text);
            File.WriteAllLines(champions, lines);

            List<string> list = new List<string>();
            using (StreamReader sr = new StreamReader(champions))
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
                mw1.lb1.Items.Add(s);
            }
            mw1.lb1.SelectedIndex = 0;
        }
        
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            editNameChampion();
            editClassChampion();
            //editStoryChampion();
            deleteImageFromDirectory();
            if (uploadFileNameWithoutExtension != null)
            {
                copyImageToDirectory();
            }
            editChampikTXT();

            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbClass.ItemsSource = mw1.list2;
            rtbHistory.AppendText(mw1.textBlock1.Text);
            imgMain.Source = mw1.image1.Source;
            var connection = new OleDbConnection(connectString);
            OleDbCommand myOleDbCommand = connection.CreateCommand();
            myOleDbCommand.CommandText = "select [class] from [tabl1] where [namee] = '" + mw1.lb1.SelectedItem.ToString() + "'";
            connection.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(myOleDbCommand);
            string classSelected = (string)da.SelectCommand.ExecuteScalar();
            connection.Close();
            cbClass.SelectedItem = classSelected;
        }

        private void imgMain_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Изображения (*.jpg)|*.jpg";
                if (opf.ShowDialog() == true)
                {
                    uploadPath = @"C:\Users\themk\source\repos\kursachwpf\kursachwpf\images\" + opf.SafeFileName;
                    uploadFilePathName = opf.FileName;
                    uploadFileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(opf.FileName);
                    imgMain.Source = new BitmapImage(new Uri(opf.FileName));
                    
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
