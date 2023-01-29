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
    /// Логика взаимодействия для PageTaskOne.xaml
    /// </summary>
    public partial class PageTaskOne : Page
    {
        public PageTaskOne()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод, который меняет цвет и стиль шрифта при получении фокуса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbUserInputString_GotFocus(object sender, RoutedEventArgs e)
        {
            string startString = tbUserInputString.Text;
            if (startString =="Введите предложение")
            {
                tbUserInputString.Foreground = Brushes.Black;
                tbUserInputString.FontStyle = FontStyles.Normal;
                tbUserInputString.Text = "";
            }
            else
            {
                tbUserInputString.Foreground = Brushes.Black;
                tbUserInputString.FontStyle = FontStyles.Normal;
                tbUserInputString.Text = "";
            }
        }

        /// <summary>
        /// Метод, который выводит каждое слово в отдельной строке в компоненте ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSplitStringIntoWords_Click(object sender, RoutedEventArgs e)
        {
            string userString = tbUserInputString.Text;
            string[] inputArray=SplitStringIntoWords(userString);

            lbWordsReceived.ItemsSource = inputArray;
        }

        /// <summary>
        /// Метод, который разделяет строку на слова
        /// </summary>
        /// <param name="inputString">Введенная пользователем строка</param>
        /// <returns></returns>
        public static string[] SplitStringIntoWords(string inputString)
        {
            string[] resultArray = inputString.Split(' ');
            return resultArray;
        }
    }
}
