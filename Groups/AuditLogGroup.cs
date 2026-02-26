namespace Glitchy_UI.Groups;

public sealed class AuditLogGroup : ObservableCollection<AuditLogViewModel>, IAuditLogGrouped
{
    public AuditLogGroup(DateOnly date, IEnumerable<AuditLogViewModel> items)
    {
        _date = date;

        foreach (AuditLogViewModel item in items)
        {
            Items.Add(item);
        }
    }

    public DateOnly Date
    {
        get => _date;

        set
        {
            if (value != _date)
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }
    }

    private DateOnly _date;

    public new event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}