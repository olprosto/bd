using System.Windows;

namespace Лучшая_работа_2
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            new MainWindow().Show(); 
        }
    }
}
