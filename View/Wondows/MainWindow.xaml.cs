using System.Windows;
using Лучшая_работа_2.Core;
using Лучшая_работа_2.View.Pages;

namespace Лучшая_работа_2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainNavCore.MainNavFrame = MainFrame;
        }

        private void BTn1_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new Task1());
        }

        private void BTn2_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new Task2());
        }

        private void BTn3_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new Task3());
        }

        private void BTn4_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new Task4());
        }

        private void BTn5_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new Task3());
        }

        private void BTn6_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new Task6());
        }

        private void BTn7_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new Task7());
        }

        private void BTn8_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new Task8());
        }

        private void BTn9_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new Task9());
        }

        private void BTn10_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new Task10());
        }

        private void BTn11_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new Task11());
        }

        private void BTn12_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new Task3());
        }
    }
}
