namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileWide310x150BlockAndText02 : IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentText TextBlock { get; }

        INotificationContentText TextBodyWrap { get; }

        INotificationContentText TextSubBlock { get; }
    }
}

