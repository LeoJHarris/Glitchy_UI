namespace Glitchy_UI.Groups;

public sealed class DocumentGroup : ObservableCollection<DocumentViewModel>, IDocumentGrouped
{
    public DocumentGroup(DocumentType documentType, IEnumerable<DocumentViewModel> items)
    {
        _documentType = documentType;

        foreach (DocumentViewModel item in items)
        {
            Items.Add(item);
        }
    }

    public DocumentType DocumentType
    {
        get => _documentType;

        set
        {
            if (value != _documentType)
            {
                _documentType = value;
                OnPropertyChanged(nameof(DocumentType));
            }
        }
    }

    private DocumentType _documentType;

    public new event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
