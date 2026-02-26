namespace Glitchy_UI.Helpers;

public static class StateKey
{
    public const string CameraCapture = nameof(CameraCapture);
    public const string CameraInitializing = nameof(CameraInitializing);
    public const string Empty = nameof(Empty);
    public const string Error = nameof(Error);
    public const string InitialLoadingCustomStateKey = nameof(InitialLoadingCustomStateKey);
    public const string Loading = nameof(Loading);
    public const string LoadingMoreCustomStateKey = nameof(LoadingMoreCustomStateKey);
    public const string MaxResultsReachedStateKey = nameof(MaxResultsReachedStateKey);
    public const string None = nameof(None);
    public const string NotFound = nameof(NotFound);

    // Camera permission states
    public const string PermissionRequired = nameof(PermissionRequired);

    public const string ReviewPhotos = nameof(ReviewPhotos);
    public const string Success = nameof(Success);
}