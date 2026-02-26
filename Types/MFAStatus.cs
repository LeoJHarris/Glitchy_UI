namespace Glitchy_UI.Types;

public enum MFAStatus
{
    /// <summary>
    /// waiting for user to confirm the code
    /// </summary>
    Pending,

    Confirmed,      // user has confirmed the code

    /// <summary>
    /// the process completed and the user was authenticated
    /// </summary>
    Completed,

    Expired,
    Cancelled
}