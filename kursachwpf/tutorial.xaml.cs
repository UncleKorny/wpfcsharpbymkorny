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

namespace kursachwpf
{
    /// <summary>
    /// Логика взаимодействия для tutorial.xaml
    /// </summary>
    public partial class tutorial : Window
    {
        MainWindow mw;
        public tutorial(MainWindow mw)
        {
            InitializeComponent();
            this.mw = mw;
        }
        public tutorial()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            mw.Show();
        }

        private void endOfTutorial_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            mw.tutorialAccept = true;
        }
    }
}
