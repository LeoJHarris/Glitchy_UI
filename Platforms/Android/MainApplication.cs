namespace Glitchy_UI;

[Application]
public class MainApplication(IntPtr handle, JniHandleOwnership ownership) : MauiApplication(handle, ownership)
{
    public override void OnCreate()
    {
        base.OnCreate();

    }

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}