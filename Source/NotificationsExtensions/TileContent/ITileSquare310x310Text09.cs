namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileSquare310x310Text09 : ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentText TextBody1 { get; }

        INotificationContentText TextBody2 { get; }

        INotificationContentText TextHeading1 { get; }

        INotificationContentText TextHeading2 { get; }

        INotificationContentText TextHeadingWrap { get; }
    }
}

