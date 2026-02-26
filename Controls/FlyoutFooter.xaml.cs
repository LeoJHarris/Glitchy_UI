namespace Glitchy_UI.Controls;

public partial class FlyoutFooter : ContentView
{
    public FlyoutFooter() => InitializeComponent();

    public IAsyncRelayCommand LogoutCommand => _logoutCommand ??= new AsyncRelayCommand(logoutCommandAsync);
    private IAsyncRelayCommand? _logoutCommand;

    private async Task logoutCommandAsync()
    {
        await Task.CompletedTask;
    }
}