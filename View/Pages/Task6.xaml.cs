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
    /// Логика взаимодействия для Task6.xaml
    /// </summary>
    public partial class Task6 : Page
    {
        public Task6()
        {
            InitializeComponent();
            bool X = false, Y = false, Z = true;

            MessageBox.Show($"1) {X || Y && !Z}\n2) {!X && !Y}\n3) {!(X && Z) || Y}",
                           "Task №6",
                           MessageBoxButton.OK,
                           MessageBoxImage.Question);
        }
    }
}
