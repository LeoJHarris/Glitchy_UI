namespace Glitchy_UI.Controls;

public partial class FlyoutHeader : ContentView
{
    public FlyoutHeader() => InitializeComponent();

    public IRelayCommand CloseHeaderCommand { get => field ??= new RelayCommand(closeHeader); private set; }

    public string HeaderTitle
    {
        get => (string)GetValue(HeaderTitleProperty);
        set => SetValue(HeaderTitleProperty, value);
    }

    public bool IsDemoModeEnabled
    {
        get => (bool)GetValue(IsDemoModeEnabledProperty);
        set => SetValue(IsDemoModeEnabledProperty, value);
    }

    public string UserHandle
    {
        get => (string)GetValue(UserHandleProperty);
        set => SetValue(UserHandleProperty, value);
    }

    public static readonly BindableProperty HeaderTitleProperty =
                        BindableProperty.Create(nameof(HeaderTitle), typeof(string), typeof(FlyoutHeader), string.Empty);

    public static readonly BindableProperty IsDemoModeEnabledProperty =
                        BindableProperty.Create(nameof(IsDemoModeEnabled), typeof(bool), typeof(FlyoutHeader), false);

    public static readonly BindableProperty UserHandleProperty =
                            BindableProperty.Create(nameof(UserHandle), typeof(string), typeof(FlyoutHeader), string.Empty);

    private void closeHeader() => Shell.Current.FlyoutIsPresented = false;
}