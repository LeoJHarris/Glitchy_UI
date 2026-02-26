namespace Glitchy_UI.Groups;

public interface INotificationsGrouped
{
    IRelayCommand? ClearGroupCommand { get; set; }
    DateTimeOffset Date { get; set; }
}