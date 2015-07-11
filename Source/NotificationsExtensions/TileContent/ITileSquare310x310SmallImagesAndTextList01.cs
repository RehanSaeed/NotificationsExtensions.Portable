namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileSquare310x310SmallImagesAndTextList01 : ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentImage Image1 { get; }

        INotificationContentImage Image2 { get; }

        INotificationContentImage Image3 { get; }

        INotificationContentText TextBodyGroup1Field1 { get; }

        INotificationContentText TextBodyGroup1Field2 { get; }

        INotificationContentText TextBodyGroup2Field1 { get; }

        INotificationContentText TextBodyGroup2Field2 { get; }

        INotificationContentText TextBodyGroup3Field1 { get; }

        INotificationContentText TextBodyGroup3Field2 { get; }

        INotificationContentText TextHeading1 { get; }

        INotificationContentText TextHeading2 { get; }

        INotificationContentText TextHeading3 { get; }
    }
}

