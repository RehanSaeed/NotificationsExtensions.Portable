namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileWide310x150Text04 : IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentText TextBodyWrap { get; }
    }
}

