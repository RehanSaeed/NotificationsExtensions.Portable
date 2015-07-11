namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileSquare150x150Text02 : ISquare150x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentText TextBodyWrap { get; }

        INotificationContentText TextHeading { get; }
    }
}

