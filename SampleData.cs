namespace Glitchy_UI;

/// <summary>
/// Static sample data provider for testing/reproduction.
/// Provides a mock user and bypasses all authentication.
/// </summary>
public static class SampleData
{
    /// <summary>
    /// Sample user for testing. Always returns the same user instance.
    /// </summary>
    public static User SampleUser { get; } = new User
    {
        Id = 1,
        Name = "Test User"
    };

    /// <summary>
    /// Creates a simple local storage service that just returns the sample user.
    /// </summary>
    public static ILocalStorageService CreateSimpleLocalStorage()
    {
        return new SimpleLocalStorageService();
    }

    private sealed class SimpleLocalStorageService : ILocalStorageService
    {
        public void AddNotification(LocalNotification notification) { }
        public void ClearUser() { }
        public long GetAccessTokenExpiry() => DateTimeOffset.Now.AddDays(1).ToUnixTimeSeconds();
        public AuditLogFilterCriteria? GetAuditLogFilter() => null;
        public Task<DevicePush?> GetDevicePushAsync() => Task.FromResult<DevicePush?>(null);
        public bool GetIsDemoModeEnabled() => true;
        public List<LocalNotification> GetNotifications() => new();
        public Task<string?> GetSecureStorageItemAsync(string key) => Task.FromResult<string?>(null);
        public LocalNotification? GetTempLocalNotification() => null;
        public User? GetUser() => SampleUser; // Always return sample user
        public bool IsFirstTimeAskingNotificationsPermission() => false;
        public void RemoveNotification(LocalNotification notification) { }
        public void RemoveNotifications(Func<LocalNotification, bool> predicate) { }
        public bool RemoveSecureStorageItem(string key) => false;
        public void SetAccessTokenExpiry(long storedUnixTimestamp) { }
        public void SetAuditLogFilter(AuditLogFilterCriteria? criteria) { }
        public Task SetDevicePushAsync(DevicePush devicePush) => Task.CompletedTask;
        public void SetFirstTimeAskingNotificationsPermission(bool value) { }
        public void SetIsDemoModeEnabled(bool value) { }
        public Task SetSecureStorageItemAsync(string key, string value) => Task.CompletedTask;
        public void SetTempLocalNotification(LocalNotification? localNotification) { }
        public void SetUser(User user) { }
    }
}


public class AuditLogFilterCriteria
{
    public DateTime? EndDate { get; set; }
    public List<string> SelectedActionTypes { get; set; } = [];
    public DateTime? StartDate { get; set; }
    public long? UserId { get; set; }
    public string? UserName { get; set; }
}


[DataContract]
public class LocalNotification
{
    [DataMember(Name = "asu")]
    public string ASU { get; set; } = string.Empty;

    [DataMember(Name = "message")]
    public string Message { get; set; } = string.Empty;

    [DataMember(Name = "mfaId")]
    public long? MfaId { get; set; }

    [DataMember(Name = "lockedOutUserId")]
    public long? LockedOutUserId { get; set; }

    [DataMember(Name = "notificationType")]
    public NotificationType NotificationType { get; set; }

    [DataMember(Name = "reauthId")]
    public long? ReauthId { get; set; }

    [IgnoreDataMember]
    public DateTimeOffset ReceivedDateTimeOffset
    {
        get => DateTimeOffset.FromUnixTimeSeconds(ReceivedDateUnixSeconds);
        set => ReceivedDateUnixSeconds = value.ToUnixTimeSeconds();
    }

    [DataMember(Name = "received")]
    public long ReceivedDateUnixSeconds { get; set; } = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
}



/// <summary>
/// Interface for local storage service to handle secure storage operations.
/// </summary>
public interface ILocalStorageService
{
    /// <summary>
    /// Adds a new notification to the notifications list and saves it.
    /// </summary>
    void AddNotification(LocalNotification notification);

    /// <summary>
    /// Clears all items from the local storage.
    /// </summary>
    void ClearUser();

    /// <summary>
    /// Gets the access token expiry time.
    /// </summary>
    /// <returns>Returns the expiry time as a Unix timestamp.</returns>
    long GetAccessTokenExpiry();

    /// <summary>
    /// Gets the audit log filter criteria.
    /// </summary>
    /// <returns>Returns the filter criteria if set, otherwise null.</returns>
    AuditLogFilterCriteria? GetAuditLogFilter();

    /// <summary>
    /// Retrieves the device push information asynchronously.
    /// </summary>
    /// <returns>Returns a <see cref="DevicePush"/> object if found, otherwise null.</returns>
    Task<DevicePush?> GetDevicePushAsync();

    /// <summary>
    /// Gets a value indicating whether demo mode is enabled.
    /// </summary>
    /// <returns>Returns <c>true</c> if demo mode is enabled; otherwise, <c>false</c>.</returns>
    bool GetIsDemoModeEnabled();

    /// <summary>
    /// Retrieves a list of local notifications.
    /// </summary>
    /// <returns>Returns a <see cref="List{T}"/> of <see cref="LocalNotification"/>.</returns>
    List<LocalNotification> GetNotifications();

    /// <summary>
    /// Retrieves a secure storage item asynchronously.
    /// </summary>
    /// <param name="key">The key of the item to retrieve.</param>
    /// <returns>Returns the value associated with the specified key, or null if not found.</returns>
    Task<string?> GetSecureStorageItemAsync(string key);

    /// <summary>
    /// Gets the temporary local notification.
    /// </summary>
    /// <returns>Returns a <see cref="Models.LocalNotification"/> if found, otherwise null.</returns>
    LocalNotification? GetTempLocalNotification();

    /// <summary>
    /// Gets the user information.
    /// </summary>
    /// <returns>Returns an <see cref="User"/> object if found, otherwise null.</returns>
    User? GetUser();

    /// <summary>
    /// Checks if it is the first time asking for notifications permission.
    /// </summary>
    /// <returns>Returns true if it is the first time, otherwise false.</returns>
    bool IsFirstTimeAskingNotificationsPermission();

    /// <summary>
    /// Removes a specific notification from the notifications list and saves the updated list.
    /// </summary>
    /// <param name="notification">The notification to remove.</param>
    void RemoveNotification(LocalNotification notification);

    /// <summary>
    /// Removes all notifications matching the given predicate and saves the updated list.
    /// </summary>
    /// <param name="predicate">Predicate used to match notifications to remove.</param>
    void RemoveNotifications(Func<LocalNotification, bool> predicate);

    /// <summary>
    /// Removes a secure storage item.
    /// </summary>
    /// <param name="key">The key of the item to remove.</param>
    /// <returns>Returns true if the item was successfully removed, otherwise false.</returns>
    bool RemoveSecureStorageItem(string key);

    /// <summary>
    /// Sets the access token expiry time.
    /// </summary>
    /// <param name="storedUnixTimestamp">The expiry time as a Unix timestamp.</param>
    void SetAccessTokenExpiry(long storedUnixTimestamp);

    /// <summary>
    /// Sets the audit log filter criteria.
    /// </summary>
    /// <param name="criteria">The filter criteria to store.</param>
    void SetAuditLogFilter(AuditLogFilterCriteria? criteria);

    /// <summary>
    /// Saves the device push information to secure storage asynchronously.
    /// </summary>
    /// <param name="devicePush">The <see cref="DevicePush"/> object to save.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task SetDevicePushAsync(DevicePush devicePush);

    /// <summary>
    /// Sets the flag indicating if it is the first time asking for notifications permission.
    /// </summary>
    /// <param name="value">The flag value to set.</param>
    void SetFirstTimeAskingNotificationsPermission(bool value);

    /// <summary>
    /// Sets a value indicating whether demo mode is enabled.
    /// </summary>
    /// <param name="value">
    /// If set to <c>true</c>, demo mode is enabled; otherwise, demo mode is disabled.
    /// </param>
    void SetIsDemoModeEnabled(bool value);

    /// <summary>
    /// Saves a secure storage item asynchronously.
    /// </summary>
    /// <param name="key">The key of the item to save.</param>
    /// <param name="value">The value to save.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task SetSecureStorageItemAsync(string key, string value);

    /// <summary>
    /// Sets the temporary local notification.
    /// </summary>
    /// <param name="localNotification">
    /// The <see cref="LocalNotification"/> object to set.
    /// </param>
    void SetTempLocalNotification(LocalNotification? localNotification);

    /// <summary>
    /// Sets the user information.
    /// </summary>
    /// <param name="user">The <see cref="User"/> object to set.</param>
    void SetUser(User user);
}