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

namespace HomeworkTheme09WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PageTaskOne pageTaskOne;
        PageTaskTwo pageTaskTwo;
        
        public MainWindow()
        {
            InitializeComponent();

            pageTaskOne= new PageTaskOne();
            pageTaskTwo= new PageTaskTwo();
        }

        private void BtnTaskOne_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = pageTaskOne;
        }

        private void BtnTaskTwo_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = pageTaskTwo;
        }
    }
}
