namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileSquare310x310SmallImagesAndTextList04 : ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentImage Image1 { get; }

        INotificationContentImage Image2 { get; }

        INotificationContentImage Image3 { get; }

        INotificationContentText TextHeading1 { get; }

        INotificationContentText TextHeading2 { get; }

        INotificationContentText TextHeading3 { get; }

        INotificationContentText TextWrap1 { get; }

        INotificationContentText TextWrap2 { get; }

        INotificationContentText TextWrap3 { get; }
    }
}

