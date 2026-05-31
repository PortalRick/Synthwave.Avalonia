using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace Synthwave.Avalonia;

public class SimpleTheme : Styles
{
    public SimpleTheme(System.IServiceProvider? sp = null)
    {
        AvaloniaXamlLoader.Load(this);
    }
}
