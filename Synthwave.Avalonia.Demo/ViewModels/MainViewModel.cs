using CommunityToolkit.Mvvm.ComponentModel;
namespace Synthwave.Avalonia.Demo.ViewModels;

public partial class MainViewModel : ViewModelBase {
    [ObservableProperty]
    private string _greeting = "Welcome to Avalonia!";
}
