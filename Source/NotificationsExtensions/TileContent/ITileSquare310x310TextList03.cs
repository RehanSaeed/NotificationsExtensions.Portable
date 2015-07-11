namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileSquare310x310TextList03 : ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentText TextHeading1 { get; }

        INotificationContentText TextHeading2 { get; }

        INotificationContentText TextHeading3 { get; }

        INotificationContentText TextWrap1 { get; }

        INotificationContentText TextWrap2 { get; }

        INotificationContentText TextWrap3 { get; }
    }
}

