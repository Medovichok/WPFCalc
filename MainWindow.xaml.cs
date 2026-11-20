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
        /// Деление
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            double operand1, operand2, result;
            if (!double.TryParse(tbFirst.Text, out operand1))
            {
                MessageBox.Show("Первое число введено неверно", "Контроль над вводом", MessageBoxButton.OK, MessageBoxImage.Error);
                tbFirst.Clear();
                tbFirst.Focus();
                return;
            }
            try
            {
                operand2 = Convert.ToDouble(tbSecond.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Второе число введено неверно", "Контроль над вводом", MessageBoxButton.OK, MessageBoxImage.Error);
                tbSecond.Clear();
                tbSecond.Focus();
                return;
            }

            Button btn = e.Source as Button;
            switch (btn.Content.ToString())
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                    result = operand1 / operand2;
                    if (operand2 == 0)
                    {
                        MessageBox.Show("Нельзя делить на ноль", "Контроль над вводом", MessageBoxButton.OK, MessageBoxImage.Error);
                        tbSecond.Clear();
                        tbSecond.Focus();
                        tbResult.Text = "Ответ:";
                        return;
                    }
                    break;
                case "^":
                    result = Math.Pow(operand1,operand2);
                    break;

                default:
                    result = operand1;
                    break;
            }

            result = operand1 / operand2;
            tbResult.Text = "Ответ: " + result;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbFirst.Clear();
            tbSecond.Clear();
            tbResult.Text = "Ответ: " + 0;
        }
    }
}
