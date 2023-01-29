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
    /// Логика взаимодействия для PageTaskTwo.xaml
    /// </summary>
    public partial class PageTaskTwo : Page
    {
        public PageTaskTwo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод, который меняет цвет и стиль шрифта при получении фокуса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbUserInputStringTwo_GotFocus(object sender, RoutedEventArgs e)
        {
            string startString = tbUserInputStringTwo.Text;
            if (startString == "Введите предложение")
            {
                tbUserInputStringTwo.Foreground = Brushes.Black;
                tbUserInputStringTwo.FontStyle = FontStyles.Normal;
                tbUserInputStringTwo.Text = "";
            }
            else
            {
                tbUserInputStringTwo.Foreground = Brushes.Black;
                tbUserInputStringTwo.FontStyle = FontStyles.Normal;
                tbUserInputStringTwo.Text = "";
            }
        }

        /// <summary>
        /// Метод, который выводит строку в обратной последовательности в компоненте Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReversWordsIntoString_Click(object sender, RoutedEventArgs e)
        {
            string userString = tbUserInputStringTwo.Text;
            lblReversString.Content= "Получившееся предложение:" + Environment.NewLine + ReversWords(userString);

        }

        /// <summary>
        /// Метод, который меняет слова в предложении местами (в обратной последовательности)
        /// </summary>
        /// <param name="inputPhrase">Введенная пользователем строка</param>
        /// <returns></returns>
        static string ReversWords(string inputPhrase)
        {
            string[] resultArray =  PageTaskOne.SplitStringIntoWords(inputPhrase);
            string resultString = "";
            for (int i = resultArray.Length - 1; i >= 0; i--)
            {
                resultString += resultArray[i] + " ";
            }

            return resultString;
        }
    }
}
