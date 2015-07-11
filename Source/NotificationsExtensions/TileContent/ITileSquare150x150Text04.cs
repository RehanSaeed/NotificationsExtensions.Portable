namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileSquare150x150Text04 : ISquare150x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentText TextBodyWrap { get; }
    }
}

