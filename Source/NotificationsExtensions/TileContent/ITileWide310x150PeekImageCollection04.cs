namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileWide310x150PeekImageCollection04 : ITileWide310x150ImageCollection, IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentText TextBodyWrap { get; }
    }
}

