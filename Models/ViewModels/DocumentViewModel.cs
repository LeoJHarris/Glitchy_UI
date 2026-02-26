namespace Glitchy_UI.Models.ViewModels;

public partial class DocumentViewModel : ObservableObject
{
    [ObservableProperty]
    public partial long DocumentID { get; set; }

    [ObservableProperty]
    public partial string DocumentName { get; set; } = string.Empty;

    [ObservableProperty]
    public partial DocumentType DocumentType { get; set; } = DocumentType.General;

    [ObservableProperty]
    public partial string? SubCategory { get; set; }

    [ObservableProperty]
    public partial VerificationStatus VerificationStatus { get; set; } = VerificationStatus.NotVerified;

    [ObservableProperty]
    public partial VisibilitySettings VisibilitySettings { get; set; } = VisibilitySettings.Private;


    [ObservableProperty]
    public partial string DocumentUrl { get; set; } = string.Empty;

    [ObservableProperty]
    public partial DateTimeOffset UploadDateInternal { get; set; }

    [ObservableProperty]
    public partial DateTimeOffset? ExpiryDateInternal { get; set; }

    [ObservableProperty]
    public partial long FileSize { get; set; }

    [ObservableProperty]
    public partial string FileSizeFormatted { get; set; } = string.Empty;

    [ObservableProperty]
    public partial string FileExtension { get; set; } = string.Empty;

    [ObservableProperty]
    public partial string? ThumbnailUrl { get; set; }

    public IAsyncRelayCommand<DocumentViewModel>? OpenDocumentCommand { get; set; }

    public bool IsExpiringSoon
    {
        get
        {
            if (ExpiryDateInternal == null)
            {
                return false;
            }

            return ExpiryDateInternal.Value <= DateTimeOffset.UtcNow.AddDays(30);
        }
    }

    public bool IsExpired
    {
        get
        {
            if (ExpiryDateInternal == null)
            {
                return false;
            }

            return ExpiryDateInternal.Value < DateTimeOffset.UtcNow;
        }
    }
}
