namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileSquare310x310SmallImagesAndTextList05 : ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentImage Image1 { get; }

        INotificationContentImage Image2 { get; }

        INotificationContentImage Image3 { get; }

        INotificationContentText TextGroup1Field1 { get; }

        INotificationContentText TextGroup1Field2 { get; }

        INotificationContentText TextGroup2Field1 { get; }

        INotificationContentText TextGroup2Field2 { get; }

        INotificationContentText TextGroup3Field1 { get; }

        INotificationContentText TextGroup3Field2 { get; }

        INotificationContentText TextHeading { get; }
    }
}

