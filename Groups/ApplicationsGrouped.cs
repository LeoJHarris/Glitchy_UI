namespace Glitchy_UI.Groups;

public class ApplicationsGrouped<K, T> : ObservableCollection<T>, IApplicationsGrouped
{
    public ApplicationsGrouped(K key, IEnumerable<T> items, Site site, int applicationsCount)
    {
        Key = key;
        SiteAddress = site.SiteAddress;
        SiteName = site.SiteName;
        ApplicationsCount = applicationsCount;

        foreach (T item in items)
        {
            Items.Add(item);
        }
    }

    public int ApplicationsCount
    {
        get;

        set
        {
            if (value != field)
            {
                field = value;
                OnPropertyChanged(nameof(ApplicationsCount));
            }
        }
    }

    public bool IsExpanded
    {
        get;

        set
        {
            if (value != field)
            {
                field = value;
                OnPropertyChanged(nameof(IsExpanded));
            }
        }
    } = false;

    public K Key { get; }

    public string SiteAddress
    {
        get;

        set
        {
            if (value != field)
            {
                field = value;
                OnPropertyChanged(nameof(SiteAddress));
            }
        }
    } = string.Empty;

    public string SiteName
    {
        get;

        set
        {
            if (value != field)
            {
                field = value;
                OnPropertyChanged(nameof(SiteName));
            }
        }
    } = string.Empty;

    public new event EventHandler<PropertyChangedEventArgs>? PropertyChanged;

    protected void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}