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
    /// Логика взаимодействия для Task9.xaml
    /// </summary>
    public partial class Task9 : Page
    {
        public Task9()
        {
            InitializeComponent();
            int x = 1, y = 2;

            MessageBox.Show($"1) {(!(x * y < 0)) || (y > x)}",
                           "Task №9.1",
                           MessageBoxButton.OK,
                           MessageBoxImage.Question);

            int x1 = 2, y1 = 1;

            MessageBox.Show($"1) {(x1 * y1 != 0) && (y1 < x1)}",
                           "Task №9.2",
                           MessageBoxButton.OK,
                           MessageBoxImage.Question);
        }
    }
}
