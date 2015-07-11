namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileSquare310x310ImageAndTextOverlay02 : ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentImage Image { get; }

        INotificationContentText TextBodyWrap { get; }

        INotificationContentText TextHeadingWrap { get; }
    }
}

