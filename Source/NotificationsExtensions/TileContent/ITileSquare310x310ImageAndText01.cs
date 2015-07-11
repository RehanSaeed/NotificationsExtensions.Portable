namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileSquare310x310ImageAndText01 : ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentImage Image { get; }

        INotificationContentText TextCaptionWrap { get; }
    }
}

