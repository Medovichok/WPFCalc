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

namespace Calculation
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Сложение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            double firstNum, secondNum, result;
            if (!double.TryParse(tbFirst.Text, out firstNum))
            {
                MessageBox.Show("Первое число введено неверно", "Контроль над вводом", MessageBoxButton.OK, MessageBoxImage.Error);
                tbFirst.Clear();
                tbFirst.Focus();
                return;
            }
            try
            {
                secondNum = Convert.ToDouble(tbSecond.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Второе число введено неверно", "Контроль над вводом", MessageBoxButton.OK, MessageBoxImage.Error);
                tbSecond.Clear();
                tbSecond.Focus();
                return;
            }
            result = firstNum + secondNum;
            tbResult.Text = "Ответ: " + result;
        }
        /// <summary>
        /// Вычитание
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            double firstNum, secondNum, result;
            if (!double.TryParse(tbFirst.Text, out firstNum))
            {
                MessageBox.Show("Первое число введено неверно", "Контроль над вводом", MessageBoxButton.OK, MessageBoxImage.Error);
                tbFirst.Clear();
                tbFirst.Focus();
                return;
            }
            try
            {
                secondNum = Convert.ToDouble(tbSecond.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Второе число введено неверно", "Контроль над вводом", MessageBoxButton.OK, MessageBoxImage.Error);
                tbSecond.Clear();
                tbSecond.Focus();
                return;
            }
            result = firstNum - secondNum;
            tbResult.Text = "Ответ: " + result;
        }
        /// <summary>
        /// Умножение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMul_Click(object sender, RoutedEventArgs e)
        {
            double firstNum, secondNum, result;
            if (!double.TryParse(tbFirst.Text, out firstNum))
            {
                MessageBox.Show("Первое число введено неверно", "Контроль над вводом", MessageBoxButton.OK, MessageBoxImage.Error);
                tbFirst.Clear();
                tbFirst.Focus();
                return;
            }
            try
            {
                secondNum = Convert.ToDouble(tbSecond.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Второе число введено неверно", "Контроль над вводом", MessageBoxButton.OK, MessageBoxImage.Error);
                tbSecond.Clear();
                tbSecond.Focus();
                return;
            }
            result = firstNum * secondNum;
            tbResult.Text = "Ответ: " + result;
        }
        /// <summary>
        /// Деление
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            double firstNum, secondNum, result;
            if (!double.TryParse(tbFirst.Text, out firstNum))
            {
                MessageBox.Show("Первое число введено неверно", "Контроль над вводом", MessageBoxButton.OK, MessageBoxImage.Error);
                tbFirst.Clear();
                tbFirst.Focus();
                return;
            }
            try
            {
                secondNum = Convert.ToDouble(tbSecond.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Второе число введено неверно", "Контроль над вводом", MessageBoxButton.OK, MessageBoxImage.Error);
                tbSecond.Clear();
                tbSecond.Focus();
                return;
            }
            if (secondNum == 0)
            {
                MessageBox.Show("Нельзя делить на ноль", "Контроль над вводом", MessageBoxButton.OK, MessageBoxImage.Error);
                tbSecond.Clear();
                tbSecond.Focus();
                tbResult.Text = "Ответ:";
                return;
            }
            result = firstNum / secondNum;
            //try
            //{
            //    result = firstNum / secondNum;
            //}
            //catch (DivideByZeroException)
            //{
            //    MessageBox.Show("Нельзя делить на ноль", "Контроль над вводом", MessageBoxButton.OK, MessageBoxImage.Error);
            //    tbSecond.Clear();
            //    tbSecond.Focus();
            //    return;
            //}
            tbResult.Text = "Ответ: " + result;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbFirst.Clear();
            tbSecond.Clear();
            tbResult.Text = "Ответ: " + 0;
        }

        private void btnPow_Click(object sender, RoutedEventArgs e)
        {
            double firstNum, secondNum, result;
            if (!double.TryParse(tbFirst.Text, out firstNum))
            {
                MessageBox.Show("Первое число введено неверно", "Контроль над вводом", MessageBoxButton.OK, MessageBoxImage.Error);
                tbFirst.Clear();
                tbFirst.Focus();
                return;
            }
            try
            {
                secondNum = Convert.ToDouble(tbSecond.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Второе число введено неверно", "Контроль над вводом", MessageBoxButton.OK, MessageBoxImage.Error);
                tbSecond.Clear();
                tbSecond.Focus();
                return;
            }
            result = Math.Pow(firstNum,secondNum);
            tbResult.Text = "Ответ: " + result;
        }
    }
}
