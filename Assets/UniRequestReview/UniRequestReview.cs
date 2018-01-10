#if UNITY_IOS && !UNITY_EDITOR
using System.Runtime.InteropServices;
#endif

/// <summary>
/// Request app review dialog at ios device (required 10.3 or higher)
/// </summary>
public class UniRequestReview
{

#if UNITY_IOS && !UNITY_EDITOR
    [DllImport ("__Internal")]
    private static extern int _RequestReview ();
#endif

    /// <summary>
    /// Request review dialog
    /// </summary>
    public static void RequestReview()
    {
#if UNITY_IOS && !UNITY_EDITOR
        _RequestReview ();
#endif
    }
}