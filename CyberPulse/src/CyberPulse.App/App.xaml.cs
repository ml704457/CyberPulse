using System.Configuration;
using System.Data;
using System.Windows;
using CyberPulse.App.ViewModels;
using CyberPulse.App.Views;
using System.Windows;

namespace CyberPulse.App;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        var vm = new MainViewModel();
        var window = new MainWindow
        {
            DataContext = vm
        };

        window.Show();
    }
}

