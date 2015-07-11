namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;
    using System.Runtime.InteropServices;
    

        public interface ISquare310x310TileNotificationContent : ITileNotificationContent, INotificationContent
    {
        bool RequireWide310x150Content { get; [param: In] set; }

        IWide310x150TileNotificationContent Wide310x150Content { get; [param: In] set; }
    }
}

