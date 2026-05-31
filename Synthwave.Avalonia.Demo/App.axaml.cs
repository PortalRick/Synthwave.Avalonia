using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Synthwave.Avalonia.Demo.ViewModels;
using Synthwave.Avalonia.Demo.Views;
namespace Synthwave.Avalonia.Demo;

public partial class App : Application {
    public override void Initialize() {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted() {
        if (this.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
            desktop.MainWindow = new MainWindow {
                DataContext = new MainViewModel()
            };
        }
        else if (this.ApplicationLifetime is IActivityApplicationLifetime
                 singleViewFactoryApplicationLifetime) {
            singleViewFactoryApplicationLifetime.MainViewFactory = () => new MainView {
                DataContext = new MainViewModel()
            };
        }
        else if (this.ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform) {
            singleViewPlatform.MainView = new MainView {
                DataContext = new MainViewModel()
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}
