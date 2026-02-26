namespace Glitchy_UI.Controls;

public partial class NoConnectionView
{
    public NoConnectionView() => InitializeComponent();

    public string Message { get => (string)GetValue(MessageProperty); set => SetValue(MessageProperty, value); }

    public string Title { get => (string)GetValue(TitleProperty); set => SetValue(TitleProperty, value); }

    public static readonly BindableProperty MessageProperty = BindableProperty.Create(
        propertyName: nameof(Message),
        returnType: typeof(string),
        declaringType: typeof(NoConnectionView));

    public static readonly BindableProperty TitleProperty = BindableProperty.Create(
       propertyName: nameof(Title),
       returnType: typeof(string),
       declaringType: typeof(NoConnectionView));
}