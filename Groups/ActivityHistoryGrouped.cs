namespace Glitchy_UI.Groups;

public class ActivityHistoryGrouped<K, T> : ObservableCollection<T>, IActivityHistoryGrouped
{
    public ActivityHistoryGrouped(K key, IEnumerable<T> items, DateTimeOffset dateTimeOffset)
    {
        Key = key;
        Date = dateTimeOffset;

        foreach (T item in items)
        {
            Items.Add(item);
        }
    }

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