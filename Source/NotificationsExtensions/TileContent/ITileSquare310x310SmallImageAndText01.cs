namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileSquare310x310SmallImageAndText01 : ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentImage Image { get; }

        INotificationContentText TextBody { get; }

        INotificationContentText TextBodyWrap { get; }

        INotificationContentText TextHeading { get; }
    }
}

