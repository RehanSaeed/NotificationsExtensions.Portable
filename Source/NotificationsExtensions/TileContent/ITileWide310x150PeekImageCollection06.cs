namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileWide310x150PeekImageCollection06 : ITileWide310x150ImageCollection, IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentImage ImageSecondary { get; }

        INotificationContentText TextHeadingWrap { get; }
    }
}

