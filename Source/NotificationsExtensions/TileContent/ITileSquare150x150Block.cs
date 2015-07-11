namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileSquare150x150Block : ISquare150x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentText TextBlock { get; }

        INotificationContentText TextSubBlock { get; }
    }
}

