namespace NotificationsExtensions
{
    using System;
    using System.Runtime.InteropServices;

    internal sealed class NotificationContentValidationException : COMException
    {
        public NotificationContentValidationException(string message) : base(message, -2147024809)
        {
        }
    }
}

