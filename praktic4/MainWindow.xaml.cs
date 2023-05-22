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

namespace praktic4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(numberTextBox.Text);
            string description = "";

            if (n >= 10 && n <= 40)
            {
                int lastDigit = n % 10;
                switch (lastDigit)
                {
                    case 1:
                        description = n + " учебное задание";
                        break;
                    case 2:
                    case 3:
                    case 4:
                        description = n + " учебных задания";
                        break;
                    default:
                        description = n + " учебных заданий";
                        break;
                }
            }

            resultLabel.Content = description;
        }
    }
}



