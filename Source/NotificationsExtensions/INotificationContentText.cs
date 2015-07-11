namespace NotificationsExtensions
{
    using System;
    using System.Runtime.InteropServices;
    

        public interface INotificationContentText
    {
        string Lang { get; [param: In] set; }

        string Text { get; [param: In] set; }
    }
}

