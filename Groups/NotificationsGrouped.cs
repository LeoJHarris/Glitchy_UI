namespace Glitchy_UI.Groups;

public class NotificationsGrouped<K, T> : ObservableCollection<T>, INotificationsGrouped
{
    public NotificationsGrouped(K key, IEnumerable<T> items, DateTimeOffset dateTimeOffset)
    {
        Key = key;
        Date = dateTimeOffset;

        foreach (T item in items)
        {
            Items.Add(item);
        }
    }

    public IRelayCommand? ClearGroupCommand { get; set; }

    public DateTimeOffset Date
    {
        get => _date;

        set
        {
            if (value != _date)
            {
                _date = value;
                OnPropertyChanged(nameof(_date));
            }
        }
    }

    public K Key { get; }

    private DateTimeOffset _date;

    public new event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}