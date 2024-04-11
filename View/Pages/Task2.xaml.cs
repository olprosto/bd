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
    public partial class Task2 : Page
    {
        public Task2()
        {
            InitializeComponent();
            bool  X = false, Y = true, Z = false;

            MessageBox.Show($"1) {X && !(Z || Y) || !Z}\n2) {!X || X && (Y || Z)}\n3) {(X || Y && !Z) && Z}",
                           "Task №2",
                           MessageBoxButton.OK,
                           MessageBoxImage.Question);
        }
    }
}
