namespace Glitchy_UI.Groups;

public interface IApplicationsGrouped
{
    int ApplicationsCount { get; set; }
    bool IsExpanded { get; set; }
    string SiteAddress { get; set; }
    string SiteName { get; set; }
}