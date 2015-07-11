namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;
    using System.Runtime.InteropServices;
    

        public interface ISquare150x150TileNotificationContent : ITileNotificationContent, INotificationContent
    {
        bool RequireSquare71x71Content { get; [param: In] set; }

        ISquare71x71TileNotificationContent Square71x71Content { get; [param: In] set; }
    }
}

