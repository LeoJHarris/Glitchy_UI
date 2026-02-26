namespace Glitchy_UI.ViewModels;

/// <summary>
/// Minimal ApplicationDetailPageViewModel for TabBar UI reproduction.
/// </summary>
public sealed partial class ApplicationDetailPageViewModel : BasePageViewModel, IQueryAttributable
{
    public ApplicationDetailPageViewModel()
    {
        CurrentPageState = "Success";
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        // Minimal implementation for TabBar reproduction
    }
}
