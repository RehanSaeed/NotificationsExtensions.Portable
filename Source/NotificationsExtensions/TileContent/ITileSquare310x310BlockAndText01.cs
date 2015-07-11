namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileSquare310x310BlockAndText01 : ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentText TextBlock { get; }

        INotificationContentText TextBody1 { get; }

        INotificationContentText TextBody2 { get; }

        INotificationContentText TextBody3 { get; }

        INotificationContentText TextBody4 { get; }

        INotificationContentText TextBody5 { get; }

        INotificationContentText TextBody6 { get; }

        INotificationContentText TextHeadingWrap { get; }

        INotificationContentText TextSubBlock { get; }
    }
}

