namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;
    using System.Runtime.InteropServices;
    

        public interface IWide310x150TileNotificationContent : ITileNotificationContent, INotificationContent
    {
        bool RequireSquare150x150Content { get; [param: In] set; }

        ISquare150x150TileNotificationContent Square150x150Content { get; [param: In] set; }
    }
}

