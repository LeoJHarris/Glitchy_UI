namespace Glitchy_UI.ViewModels;

/// <summary>
/// Minimal AuditLogPageViewModel for TabBar UI reproduction with inline sample data.
/// No service dependencies - completely self-contained.
/// </summary>
public partial class AuditLogPageViewModel : BasePageViewModel, IQueryAttributable
{
    public AuditLogPageViewModel()
    {
        CurrentPageState = "Loading";

        // Load sample data directly (no services needed)
        _ = Task.Run(async () =>
        {
            await Task.Delay(100);
            await MainThread.InvokeOnMainThreadAsync(RefreshPageAsync);
        });
    }

    public ObservableCollection<AuditLogGroup> AuditLogs { get; set; } = [];

    [ObservableProperty]
    public partial bool HasActiveFilters { get; set; }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
    }

    protected override Task PullToRefreshPageAsync() => RefreshPageAsync();

    protected override Task RefreshPageAsync()
    {
        try
        {
            CurrentPageState = "Loading";

            // Generate inline sample data
            List<AuditLogViewModel> itemViewModels = GenerateSampleAuditLogs();

            List<AuditLogGroup> groups = itemViewModels
                .Where(x => x.LogDateOnly.HasValue)
                .GroupBy(x => x.LogDateOnly!.Value)
                .OrderByDescending(g => g.Key)
                .Select(g => new AuditLogGroup(g.Key, g.OrderByDescending(x => x.LogDate)))
                .ToList();

            AuditLogs.Clear();
            foreach (var group in groups)
            {
                AuditLogs.Add(group);
            }

            CurrentPageState = "Success";
        }
        catch (Exception)
        {
            CurrentPageState = "Error";
        }
        finally
        {
            IsRefreshing = false;
        }

        return Task.CompletedTask;
    }

    private List<AuditLogViewModel> GenerateSampleAuditLogs()
    {
        var actions = new[] { AuditLogAction.LoginSuccess, AuditLogAction.Logout, AuditLogAction.Reauth, AuditLogAction.AccountLocked };
        var sites = new[] { "Main Office", "Branch Office", "Remote Site" };
        var apps = new[] { "HR Portal", "Finance System", "CRM", "Email" };
        var users = new[] { "John Doe", "Jane Smith", "Bob Johnson", "Alice Williams" };
        var random = new Random(42);

        var logs = new List<AuditLogViewModel>();

        for (int i = 0; i < 50; i++)
        {
            logs.Add(new AuditLogViewModel
            {
                AuditLogID = i + 1,
                Action = actions[random.Next(actions.Length)],
                LogDate = DateTimeOffset.Now.AddDays(-random.Next(0, 30)),
                SiteName = sites[random.Next(sites.Length)],
                AppName = apps[random.Next(apps.Length)],
                UserName = users[random.Next(users.Length)],
                IpAddress = $"192.168.1.{random.Next(1, 255)}",
                OpenAuditLogDetailCommand = OpenAuditLogDetailCommand
            });
        }

        return logs;
    }

    [RelayCommand]
    private Task OpenAuditLogDetailAsync(AuditLogViewModel auditLog)
    {
        return Task.CompletedTask;
    }

    [RelayCommand]
    private Task OpenFilterBottomSheetAsync()
    {
        return Task.CompletedTask;
    }
}
