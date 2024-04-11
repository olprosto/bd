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

namespace Лучшая_работа_2.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task3.xaml
    /// </summary>
    public partial class Task3 : Page
    {
        public Task3()
        {
            InitializeComponent();
            int x = 2, y = 1;

            MessageBox.Show($"1) {!(x * y < 0) && (y > x)}",
                           "Task №3.1",
                           MessageBoxButton.OK,
                           MessageBoxImage.Question);

            int x1 = 2, y1 = -2;

            MessageBox.Show($"1) {(x1 >= 2) || (Math.Pow(y1,2) != 5)}",
                           "Task №3.2",
                           MessageBoxButton.OK,
                           MessageBoxImage.Question);
        }
    }
}
