namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileWide310x150PeekImage06 : IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentImage ImageMain { get; }

        INotificationContentImage ImageSecondary { get; }

        INotificationContentText TextHeadingWrap { get; }
    }
}

