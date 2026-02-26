namespace Glitchy_UI.Controls;

public partial class ErrorView
{
    public ErrorView() => InitializeComponent();

    public string Message { get => (string)GetValue(MessageProperty); set => SetValue(MessageProperty, value); }

    public IRelayCommand RefreshCommand { get => (IRelayCommand)GetValue(RefreshCommandProperty); set => SetValue(RefreshCommandProperty, value); }

    public static readonly BindableProperty MessageProperty = BindableProperty.Create(propertyName: nameof(Message),
       returnType: typeof(string),
       declaringType: typeof(ErrorView));

    public static readonly BindableProperty RefreshCommandProperty = BindableProperty.Create(propertyName: nameof(RefreshCommand),
        returnType: typeof(IRelayCommand),
        declaringType: typeof(ErrorView));
}