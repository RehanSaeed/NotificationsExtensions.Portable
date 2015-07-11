namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileSquare310x310TextList02 : ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentText TextWrap1 { get; }

        INotificationContentText TextWrap2 { get; }

        INotificationContentText TextWrap3 { get; }
    }
}

