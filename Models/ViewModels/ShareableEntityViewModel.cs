namespace Glitchy_UI.Models.ViewModels;

public partial class ShareableEntityViewModel : ObservableObject
{
    [ObservableProperty]
    public partial long Id { get; set; }

    [ObservableProperty]
    public partial bool IsSelected { get; set; }

    public bool IsSite => Type?.Equals("site", StringComparison.OrdinalIgnoreCase) ?? false;

    public bool IsUser => Type?.Equals("user", StringComparison.OrdinalIgnoreCase) ?? false;

    [ObservableProperty]
    public partial string? Name { get; set; }

    public IRelayCommand<ShareableEntityViewModel>? SelectEntityCommand { get; set; }

    [ObservableProperty]
    public partial string? Subtitle { get; set; }

    [ObservableProperty]
    public partial string? Type { get; set; }
}
