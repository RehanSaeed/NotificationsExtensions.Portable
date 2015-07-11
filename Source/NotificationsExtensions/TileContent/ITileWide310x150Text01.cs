﻿namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileWide310x150Text01 : IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentText TextBody1 { get; }

        INotificationContentText TextBody2 { get; }

        INotificationContentText TextBody3 { get; }

        INotificationContentText TextBody4 { get; }

        INotificationContentText TextHeading { get; }
    }
}

