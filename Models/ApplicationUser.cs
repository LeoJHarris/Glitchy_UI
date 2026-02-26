namespace Glitchy_UI.Models;

[DataContract]
public class ApplicationUser
{
    public DateTimeOffset? AccessEndDate => string.IsNullOrWhiteSpace(AccessEndDateStr) ? null : DateTimeOffset.Parse(AccessEndDateStr);

    [DataMember(Name = "accessEndDate")]
    public string? AccessEndDateStr { get; set; }

    public DateTimeOffset? AccessStartDate => string.IsNullOrWhiteSpace(AccessStartDateStr) ? null : DateTimeOffset.Parse(AccessStartDateStr);

    [DataMember(Name = "accessStartDate")]
    public string? AccessStartDateStr { get; set; }

    [DataMember(Name = "applicationId")]
    public long ApplicationId { get; set; }

    [DataMember(Name = "created")]
    public string Created { get; set; } = string.Empty;

    public DateTimeOffset? CreatedInternal => string.IsNullOrWhiteSpace(Created) ? null : DateTimeOffset.Parse(Created);

    [DataMember(Name = "enabled")]
    public bool Enabled { get; set; }

    public DateTimeOffset? LastMfaCompleted => string.IsNullOrWhiteSpace(LastMfaCompletedStr) ? null : DateTimeOffset.Parse(LastMfaCompletedStr);

    [DataMember(Name = "lastMfaCompleted")]
    public string? LastMfaCompletedStr { get; set; }

    public DateTimeOffset? LastReauth => string.IsNullOrWhiteSpace(LastReauthStr) ? null : DateTimeOffset.Parse(LastReauthStr);

    [DataMember(Name = "lastReauth")]
    public string? LastReauthStr { get; set; }

    public DateTimeOffset? LastSignInFailure => string.IsNullOrWhiteSpace(LastSignInFailureStr) ? null : DateTimeOffset.Parse(LastSignInFailureStr);

    [DataMember(Name = "lastSignInFailure")]
    public string? LastSignInFailureStr { get; set; }

    public DateTimeOffset? LastSignInSuccess => string.IsNullOrWhiteSpace(LastSignInSuccessStr) ? null : DateTimeOffset.Parse(LastSignInSuccessStr);

    [DataMember(Name = "lastSignInSuccess")]
    public string? LastSignInSuccessStr { get; set; }

    [DataMember(Name = "siteId")]
    public long SiteId { get; set; }

    [DataMember(Name = "updated")]
    public string Updated { get; set; } = string.Empty;

    [DataMember(Name = "updatedByUserID")]
    public long? UpdatedByUserID { get; set; }

    public DateTimeOffset? UpdatedInternal => string.IsNullOrWhiteSpace(Updated) ? null : DateTimeOffset.Parse(Updated);

    [DataMember(Name = "userId")]
    public long UserId { get; set; }
}